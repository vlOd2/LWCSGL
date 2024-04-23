#define ONLY_MANAGED_TYPES
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace LWCSGL.Bindgen
{
    public class BindingsGenerator
    {
        private const string PTR_FUNC_PREFIX = "_";
        private const string TARGET_PROFILE = "core";

        private static readonly string[] RESERVED_KEYWORDS = new string[]
        {
            "abstract", "as", "base", "bool",
            "break", "byte", "case", "catch",
            "char", "checked", "class", "const",
            "continue", "decimal", "default", "delegate",
            "do", "double", "else", "enum",
            "event", "explicit", "extern", "false",
            "finally", "fixed", "float", "for",
            "foreach", "goto", "if", "implicit",
            "in", "int", "interface", "internal",
            "is", "lock", "long", "namespace",
            "new", "null", "object", "operator",
            "out", "override", "params", "private",
            "protected", "public", "readonly", "ref",
            "return", "sbyte", "sealed", "short",
            "sizeof", "stackalloc", "static", "string",
            "struct", "switch", "this", "throw",
            "true", "try", "typeof", "uint",
            "ulong", "unchecked", "unsafe", "ushort",
            "using", "virtual", "void", "volatile", "while"
        };

        private readonly XmlDocument xml;
        private readonly StringBuilder sb;
        private HashSet<string> allowedEnums;
        private HashSet<string> allowedFunctions;
        private int indent;

        public BindingsGenerator(string fileName)
        {
            if (!File.Exists(fileName)) 
                throw new ArgumentException("Specified file doesn't exist!");
            sb = new StringBuilder();
            xml = new XmlDocument();
            xml.Load(fileName);
        }

        public void GenerateAPI(string[] targetFeatures, string[] targetExtensions, string revision)
        {
            string revisionID = revision.Replace(".", "");
            allowedEnums = new HashSet<string>();
            allowedFunctions = new HashSet<string>();
            sb.Clear();
            indent = 0;

            Console.WriteLine($"------------- OpenGL {revision} ({revisionID}) -------------");
            Console.WriteLine("Parsing XML");
            ParseFExt(xml.SelectNodes(".//feature"), targetFeatures);
            ParseFExt(xml.SelectNodes(".//extension"), targetExtensions);

            Console.WriteLine("Writing constants");
            sb.AppendLine("#pragma warning disable 1591");
            sb.AppendLine();
            sb.AppendLine("namespace LWCSGL.OpenGL");
            sb.AppendLine("{");
            indent++;

            AppendIndent();
            sb.AppendLine(@"/// <summary>");
            AppendIndent();
            sb.AppendLine(@$"/// Constants for OpenGL {revision}");
            AppendIndent();
            sb.AppendLine(@"/// </summary>");
            AppendIndent();
            sb.AppendLine($"public class GL{revisionID}C");
            AppendIndent();
            sb.AppendLine("{");
            indent++;

            foreach (XmlNode enumGroupNode in xml.SelectNodes(".//enums"))
            {
                foreach (XmlNode enumNode in enumGroupNode.SelectNodes(".//enum"))
                {
                    string name = enumNode.Attributes["name"].Value;
                    if (!allowedEnums.Contains(name)) continue;

                    AppendIndent();
                    sb.Append("public const uint ");
                    sb.Append(name);
                    sb.Append(" = ");
                    sb.Append(enumNode.Attributes["value"].Value);
                    sb.Append('u');
                    sb.Append(';');
                    sb.AppendLine();
                }
            }
            indent--;
            AppendIndent();
            sb.AppendLine("}");
            sb.AppendLine("}");

            File.WriteAllText($"GL{revisionID}C.cs", sb.ToString());
            Console.WriteLine("Saved the constants");
            indent = 0;
            sb.Clear();


            Console.WriteLine("Writing bindings");
            sb.AppendLine("#pragma warning disable 1591");
            sb.AppendLine();
            sb.AppendLine("namespace LWCSGL.OpenGL");
            sb.AppendLine("{");
            indent++;

            AppendIndent();
            sb.AppendLine(@"/// <summary>");
            AppendIndent();
            sb.AppendLine(@$"/// OpenGL {revision} APIs");
            AppendIndent();
            sb.AppendLine(@"/// </summary>");
            AppendIndent();
            sb.AppendLine($"public unsafe static class GL{revisionID}");
            AppendIndent();
            sb.AppendLine("{");
            indent++;

            List<Function> functions = new List<Function>();
            Console.WriteLine("Parsing commands");

            XmlNode commandNode = xml.DocumentElement["commands"];
            foreach (XmlNode cmd in commandNode.ChildNodes)
            {
                if (cmd.Name != "command") continue;

                XmlNode protoNode = cmd["proto"];
                string cmdName = protoNode["name"].InnerText;
                if (!allowedFunctions.Contains(cmdName)) continue;

                string cmdReturnType;

                if (protoNode["ptype"] != null)
                    cmdReturnType = TranslateType(protoNode["ptype"].InnerText.Trim());
                else
                    cmdReturnType = "void";

#if ONLY_MANAGED_TYPES
                if (cmdReturnType.Contains("*"))
                    cmdReturnType = "nint";
#endif

                string pit = protoNode.InnerText;
                for (int i = 0; i < pit.Length; i++)
                {
                    if (pit[i] == '*')
                    {
#if ONLY_MANAGED_TYPES
                        cmdReturnType = "nint";
                        break;
#else
                        cmdReturnType += '*';
#endif
                    }
                }

                bool parsedOk = true;
                List<Parameter> prm = new List<Parameter>();

                foreach (XmlNode paramNode in cmd.SelectNodes(".//param"))
                {
                    XmlNode typeNode = paramNode["ptype"];
                    string pType;
                    if (typeNode != null)
                    {
                        pType = typeNode.InnerText;
                        try
                        {
                            pType = TranslateType(pType);
                            string it = paramNode.InnerText;
                            for (int i = 0; i < it.Length; i++)
                            {
                                if (it[i] == '*')
                                    pType += '*';
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine($"Parsing failed on function '{cmdName}'");
                            parsedOk = false;
                            break;
                        }
                    }
                    else
                    {
                        pType = paramNode.FirstChild.Value;
                        pType = pType.Replace("const", "").Replace(" ", "");
                    }

#if ONLY_MANAGED_TYPES
                    if (pType.Contains('*') && !pType.Contains("void"))
                        pType = pType.Replace("*", "[]");
                    else if (pType.Contains("void"))
                        pType = "nint";
#endif

                    string pName = paramNode["name"].InnerText;
                    prm.Add(new Parameter(pType, pName));
                }

                if (parsedOk)
                    functions.Add(new Function(cmdReturnType, cmdName, prm.ToArray()));
            }

            Console.WriteLine("Generating function handles");
            for (int i = 0; i < functions.Count; i++)
            {
                Function func = functions[i];

                AppendIndent();
                sb.Append("private static delegate* unmanaged[Stdcall]<");

                for (int j = 0; j < func.Params.Length; j++)
                {
                    Parameter p = func.Params[j];
                    sb.Append(p.Type);
                    sb.Append(',');
                    sb.Append(' ');
                }

                sb.Append(func.ReturnType);
                sb.Append('>');
                sb.Append(' ');
                sb.Append(PTR_FUNC_PREFIX);
                sb.Append(func.FuncName);
                sb.Append(';');
                sb.AppendLine();
            }
            sb.AppendLine();

            Console.WriteLine("Generating function signatures");
            for (int i = 0; i < functions.Count; i++)
            {
                Function func = functions[i];

                AppendIndent();
                sb.Append("public static ");
                sb.Append(func.ReturnType);
                sb.Append(' ');
                sb.Append(func.FuncName);
                sb.Append('(');

                for (int j = 0; j < func.Params.Length; j++)
                {
                    Parameter p = func.Params[j];
                    sb.Append(p.Type);
                    sb.Append(' ');
                    sb.Append(EscapeReserved(p.Name));

                    if (j < func.Params.Length - 1)
                    {
                        sb.Append(',');
                        sb.Append(' ');
                    }
                }

                sb.Append(')');
                sb.Append(' ');
                sb.Append('{');
                sb.Append(' ');

                if (func.ReturnType != "void")
                    sb.Append("return ");

                sb.Append(PTR_FUNC_PREFIX);
                sb.Append(func.FuncName);
                sb.Append('(');

                for (int j = 0; j < func.Params.Length; j++)
                {
                    Parameter p = func.Params[j];
                    sb.Append(EscapeReserved(p.Name));

                    if (j < func.Params.Length - 1)
                    {
                        sb.Append(',');
                        sb.Append(' ');
                    }
                }

                sb.Append(')');
                sb.Append(';');
                sb.Append(' ');
                sb.Append('}');
                sb.AppendLine();
            }
            sb.AppendLine();

            Console.WriteLine("Generating Load()");
            AppendIndent();
            sb.Append("internal static void Load(DelegatePtrSource src)");
            sb.AppendLine();
            AppendIndent();
            sb.Append('{');
            sb.AppendLine();
            indent++;

            for (int i = 0; i < functions.Count; i++)
            {
                Function func = functions[i];

                AppendIndent();
                sb.Append(PTR_FUNC_PREFIX);
                sb.Append(func.FuncName);
                sb.Append(" = ");
                sb.Append("(delegate* unmanaged[Stdcall]<");

                for (int j = 0; j < func.Params.Length; j++)
                {
                    Parameter p = func.Params[j];
                    sb.Append(p.Type);
                    sb.Append(',');
                    sb.Append(' ');
                }

                sb.Append(func.ReturnType);
                sb.Append('>');
                sb.Append(')');
                sb.Append("src.GetFuncPtr(\"");
                sb.Append(func.FuncName);
                sb.Append("\");");
                sb.AppendLine();
            }
            indent--;
            AppendIndent();
            sb.AppendLine("}");

            Console.WriteLine("Generating Unload()");
            sb.AppendLine();
            AppendIndent();
            sb.Append("internal static void Unload()");
            sb.AppendLine();
            AppendIndent();
            sb.Append('{');
            sb.AppendLine();
            indent++;

            for (int i = 0; i < functions.Count; i++)
            {
                Function func = functions[i];
                AppendIndent();
                sb.Append(PTR_FUNC_PREFIX);
                sb.Append(func.FuncName);
                sb.Append(" = null;");
                sb.AppendLine();
            }
            indent--;
            AppendIndent();
            sb.AppendLine("}");

            indent--;
            AppendIndent();
            sb.AppendLine("}");
            sb.AppendLine("}");

            File.WriteAllText($"GL{revisionID}.cs", sb.ToString());
            Console.WriteLine("Saved the bindings");
        }

        private void ParseFExt(XmlNodeList nodes, string[] target)
        {
            foreach (XmlNode featureNode in nodes)
            {
                bool use = false;
                for (int i = 0; i < target.Length; i++)
                {
                    if (target[i] == featureNode.Attributes["name"].Value)
                    {
                        use = true;
                        break;
                    }
                }
                if (!use) continue;

                foreach (XmlNode reqNode in featureNode.SelectNodes(".//require"))
                {
                    foreach (XmlNode enumNode in reqNode.SelectNodes(".//enum"))
                        allowedEnums.Add(enumNode.Attributes["name"].Value);

                    foreach (XmlNode funcNode in reqNode.SelectNodes(".//command")) 
                        allowedFunctions.Add(funcNode.Attributes["name"].Value);
                }

                foreach (XmlNode remNode in featureNode.SelectNodes(".//remove"))
                {
                    if (remNode.Attributes["profile"].Value != TARGET_PROFILE) continue;

                    foreach (XmlNode enumNode in remNode.SelectNodes(".//enum"))
                        allowedEnums.Remove(enumNode.Attributes["name"].Value);

                    foreach (XmlNode funcNode in remNode.SelectNodes(".//command"))
                        allowedFunctions.Remove(funcNode.Attributes["name"].Value);
                }
            }
        }

        private void AppendIndent()
        {
            for (int i = 0; i < indent * 4; i++)
                sb.Append(' ');
        }

        private static string EscapeReserved(string s)
        {
            for (int i = 0; i < RESERVED_KEYWORDS.Length; i++)
            {
                if (s == RESERVED_KEYWORDS[i])
                {
                    s = '@' + s;
                    break;
                }
            }

            return s;
        }

        private static string TranslateType(string glType)
        {
            switch (glType)
            {
                case "GLenum": return "uint";
                case "GLboolean": return "bool";
                case "GLbitfield": return "uint";
                case "GLvoid": return "void";
                case "GLbyte": return "sbyte";
                case "GLubyte": return "byte";
                case "GLshort": return "short";
                case "GLushort": return "ushort";
                case "GLint": return "int";
                case "GLuint": return "uint";
                case "GLclampx": return "int";
                case "GLsizei": return "int";
                case "GLfloat": return "float";
                case "GLclampf": return "float";
                case "GLdouble": return "double";
                case "GLclampd": return "double";
                case "GLeglClientBufferEXT": return "nint";
                case "GLeglImageOES": return "nint";
                case "GLchar": return "char";
                case "GLcharARB": return "char";
                case "GLhandleARB": return "uint";
                case "GLhalf": return "ushort";
                case "GLhalfARB": return "ushort";
                case "GLfixed": return "int";
                case "GLintptr": return "nint";
                case "GLintptrARB": return "nint";
                case "GLsizeiptr": return "nint";
                case "GLsizeiptrARB": return "nint";
                case "GLint64": return "long";
                case "GLint64EXT": return "long";
                case "GLuint64": return "ulong";
                case "GLuint64EXT": return "ulong";
                case "GLsync": return "nint";
                case "GLvdpauSurfaceNV": return "nint";
                case "GLhalfNV": return "ushort";
                case "GLVULKANPROCNV": return "GLVULKANPROCNV";
                default:
                    throw new Exception($"Bad GLType {glType}");
            }
        }
    }
}
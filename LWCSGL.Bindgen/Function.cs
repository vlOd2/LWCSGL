namespace LWCSGL.Bindgen
{
    public readonly struct Function
    {
        public readonly string ReturnType;
        public readonly string FuncName;
        public readonly Parameter[] Params;

        public Function(string returnType, string funcName, Parameter[] @params)
        {
            ReturnType = returnType;
            FuncName = funcName;
            Params = @params;
        }
    }
}
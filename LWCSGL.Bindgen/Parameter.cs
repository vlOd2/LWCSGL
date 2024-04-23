namespace LWCSGL.Bindgen
{
    public readonly struct Parameter
    {
        public readonly string Type;
        public readonly string Name;

        public Parameter(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
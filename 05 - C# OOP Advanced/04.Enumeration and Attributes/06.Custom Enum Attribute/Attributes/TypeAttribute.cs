namespace _06.Custom_Enum_Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        public string Type { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}
using System;

namespace Custom.Object.Extensions.Object
{
    public static class TypeExtension
    {
        public static TypeDescription GetDescriptionObject(this Type type)
        {
            return new TypeDescription
            {
                AssemblyQualifiedName = type.AssemblyQualifiedName,
                FullName = type.FullName
            };
        }
    }
    public class TypeDescription
    {
        public string FullName { get; set; }
        public string AssemblyQualifiedName { get; set; }
    }
}

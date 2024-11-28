using System;

namespace Utility
{
    public class StringRepresentationAttribute : Attribute
    {
        private readonly string _value;

        public StringRepresentationAttribute(string value)
        {
            _value = value;
        }

        public string Value => _value;
    }
    
    public static class StringValueEnumExtensions
    {
        public static string GetStringRepresentation<T>(this T value) where T : Enum
        {
            string output = null;
            var type = value.GetType();

            var fi = type.GetField(value.ToString());
            var attrs =
                fi.GetCustomAttributes(typeof(StringRepresentationAttribute),
                    false) as StringRepresentationAttribute[];
            if (attrs != null && attrs.Length > 0)
            {
                output = attrs[0].Value;
            }
            else if (attrs == null)
            {
                throw new Exception(string.Format(
                    "Can not get {0} via reflection - are you missing a attribute of type {0} for value {1}?",
                    typeof(T).Name, value));
            }

            return output;
        }
    }
}
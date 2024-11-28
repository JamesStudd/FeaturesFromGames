using System.Collections.Generic;
using System.Text;

namespace Utility.Extensions
{
    public static class DictionaryExtensions
    {
        public static string ToNewLinedString<T>(this Dictionary<string, T> dictionary)
        {
            var sb = new StringBuilder();
            
            dictionary.ForEach(kvp =>
            {
                sb.AppendLine($"{kvp.Key} : {kvp.Value}");
            });

            return sb.ToString();
        }
    }
}
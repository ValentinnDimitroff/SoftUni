namespace _01HarestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            FieldInfo[] allFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            
            Dictionary<string, Func<FieldInfo[]>> accModifiersFilters = new Dictionary<string, Func<FieldInfo[]>>
                {
                    {"public", () => allFields.Where(f => f.IsPublic).ToArray() },
                    {"private", () => allFields.Where(f => f.IsPrivate).ToArray() },
                    {"protected", () => allFields.Where(f => f.IsFamily).ToArray() },
                    {"all", () => allFields }
                };

            string inputRequest;
            while ((inputRequest = Console.ReadLine()) != "HARVEST")
            {
                if (accModifiersFilters.ContainsKey(inputRequest))
                {
                    accModifiersFilters[inputRequest]()
                        .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                        .ToList()
                        .ForEach(f => Console.WriteLine(f.Replace("family", "protected")));
                }
            }
        }
    }
}
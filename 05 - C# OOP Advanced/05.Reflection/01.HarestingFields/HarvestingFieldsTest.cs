namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            FieldInfo[] allFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            FieldInfo[] gatheredFields;

            string inputRequest;
            while ((inputRequest = Console.ReadLine()) != "HARVEST")
            {
                switch (inputRequest)
                {
                    case "public":
                        gatheredFields = allFields.Where(f => f.IsPublic).ToArray();
                        break;
                    case "private":
                        gatheredFields = allFields.Where(f => f.IsPrivate).ToArray();
                        break;
                    case "protected":
                        gatheredFields = allFields.Where(f => f.IsFamily).ToArray();
                        break;
                    case "all":
                        gatheredFields = allFields;
                        break;
                    default:
                        continue;
                }

                string[] result = gatheredFields.Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}").ToArray();
                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
            }
        }
    }
}
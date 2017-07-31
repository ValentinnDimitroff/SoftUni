namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxIntType = typeof(BlackBoxInt);
            ConstructorInfo blackBoxCtor = blackBoxIntType
                .GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                    null,
                    Type.EmptyTypes,
                    null);
            BlackBoxInt myBlackBox = (BlackBoxInt)blackBoxCtor.Invoke(new object[] {});

            FieldInfo[] fields = blackBoxIntType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            string fieldName = fields.FirstOrDefault().Name;

            string inputRequest;
            while ((inputRequest = Console.ReadLine()) != "END")
            {
                string[] tokens = inputRequest.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                blackBoxIntType
                    .GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(myBlackBox, new object[] {value});

                string innerState = blackBoxIntType
                    .GetField(
                        fieldName,
                        BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(myBlackBox).ToString();

                Console.WriteLine(innerState);
            }
        }
    }
}

namespace ClassBoxDataValidation
{
    using System;
    using System.Linq;
    using System.Reflection;
    public class Startup
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var boxParams = new double[3];
            for (int i = 0; i < boxParams.Length; i++)
            {
                boxParams[i] = double.Parse(Console.ReadLine());
            }

            try
            {
                var box = new Box(boxParams[0], boxParams[1], boxParams[2]);

                var surfaceArea = box.GetSurfaceArea();
                var lateralSurface = box.GetLateralSurfaceArea();
                var volume = box.GetVolume();

                Console.WriteLine($"Surface Area - {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurface:f2}");
                Console.WriteLine($"Volume - {volume:f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

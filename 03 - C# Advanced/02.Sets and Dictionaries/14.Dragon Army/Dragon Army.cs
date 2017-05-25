using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dragon_Army
{
    public class Dragon_Army
    {
        private const int DEFAULT_DMG  = 45;
        private const int DEFAULT_HLT  = 250;
        private const int DEFAULT_ARM  = 10;
        public static void Main()
        {
            int dragonsCount = int.Parse(Console.ReadLine());
            var allDragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < dragonsCount; i++)
            {
                var dragonParams = Console.ReadLine()
                    .Split();

                var dragonType = dragonParams[0];
                var dragonName = dragonParams[1];
                int damage = dragonParams[2].Equals("null") ? DEFAULT_DMG : int.Parse(dragonParams[2]);
                int health = dragonParams[3].Equals("null") ? DEFAULT_HLT : int.Parse(dragonParams[3]);
                int armor = dragonParams[4].Equals("null") ? DEFAULT_ARM : int.Parse(dragonParams[4]);
                

                if (allDragons.ContainsKey(dragonType))
                {
                    allDragons[dragonType][dragonName] = new[] { damage, health, armor };
                }
                else
                {
                    allDragons[dragonType] = new SortedDictionary<string, int[]> { { dragonName, new[] { damage, health, armor } } };
                }
            }

            PrintDragons(allDragons);
        }

        private static void PrintDragons(Dictionary<string, SortedDictionary<string, int[]>> allDragons)
        {
            foreach (var dragonType in allDragons)
            {
                double avrDamage = 0, avrHealth = 0, avrArmor = 0;
                var dragonsFromType = new StringBuilder();
                foreach (var dragon in dragonType.Value)
                {
                    dragonsFromType.Append($"-{dragon.Key} -> damage: {dragon.Value[0]}, " + 
                        $"health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                    dragonsFromType.Append("\r\n");
                    avrDamage += dragon.Value[0];
                    avrHealth += dragon.Value[1];
                    avrArmor += dragon.Value[2];
                }
                avrDamage /= dragonType.Value.Count();
                avrHealth /= dragonType.Value.Count();
                avrArmor /= dragonType.Value.Count();

                Console.WriteLine($"{dragonType.Key}::({avrDamage:f2}/{avrHealth:f2}/{avrArmor:f2})");
                Console.Write(string.Join("", dragonsFromType));
            }
        }
    }
}

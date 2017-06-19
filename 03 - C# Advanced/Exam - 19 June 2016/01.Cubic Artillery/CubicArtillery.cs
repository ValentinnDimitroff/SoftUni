using System;
using System.Collections.Generic;

public class CubicArtillery
{
    private static int _bunkersCapacity;

    public static void Main()
    {
        _bunkersCapacity = int.Parse(Console.ReadLine());
        var bunkers = new List<Bunker>();
        string inputWeapons;

        while ((inputWeapons = Console.ReadLine()) != "Bunker Revision")
        {
            var tokens = inputWeapons.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var element in tokens)
            {
                int weapon;
                var isDigit = int.TryParse(element, out weapon);
                if (!isDigit)
                {
                    bunkers.Add(new Bunker(element, new Queue<int>(), 0));
                }
                else
                {
                    var managed = CheckBunkersForSpace(bunkers, weapon);
                    if (!managed && bunkers.Count == 1)
                    {
                        EmptySpaceForNewWeapon(bunkers, weapon);
                    }
                }
            }
        }
    }

    private static void EmptySpaceForNewWeapon(List<Bunker> bunkers, int weapon)
    {
        while (_bunkersCapacity - bunkers[0].FilledRate < weapon)
            bunkers[0].FilledRate -= bunkers[0].Weapons.Dequeue();
        
        bunkers[0].Weapons.Enqueue(weapon);
        bunkers[0].FilledRate += weapon;
    }

    private static bool CheckBunkersForSpace(List<Bunker> bunkers, int weapon)
    {
        int i = 0;
        while (i < bunkers.Count) 
        {
            if (_bunkersCapacity < bunkers[i].FilledRate + weapon && bunkers.Count > 1)
            {
                PrintBunkerOverflow(bunkers, i);
                bunkers.RemoveAt(i);
            }

            if (weapon > _bunkersCapacity)
                return true; //Ignore

            if (_bunkersCapacity - bunkers[i].FilledRate >= weapon)
            {
                bunkers[i].Weapons.Enqueue(weapon);
                bunkers[i].FilledRate += weapon;
                return true;
            }
            i++;
        }

        return false;
    }

    private static void PrintBunkerOverflow(List<Bunker> bunkers, int i)
    {
        if (bunkers[i].Weapons.Count == 0)
        {
            Console.WriteLine($"{bunkers[i].Name} -> Empty");
        }
        else
        {
            Console.WriteLine(bunkers[i].Name + " -> " + string.Join(", ", bunkers[i].Weapons));
        }
    }
}

public class Bunker
{
    public string Name { get; set; }
    public Queue<int> Weapons { get; set; }
    public int FilledRate { get; set; }

    public Bunker(string name, Queue<int> weapons, int filledRate)
    {
        this.Name = name;
        this.Weapons = weapons;
        this.FilledRate = filledRate;
    }
}
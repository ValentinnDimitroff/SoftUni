namespace _11.Inferno_Infinity
{
    using System;
    using System.Collections.Generic;
    using Entities;
    using Factories;
    using Interfaces;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, IWeapon> weapons = new Dictionary<string, IWeapon>();
            WeaponFactory weapongFactory = new WeaponFactory();
            GemFactory gemFactory = new GemFactory();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] commandArgs = inputLine.Split(';');
                string commandType = commandArgs[0];
                
                switch (commandType)
                {
                    case "Create":
                        weapons.Add(commandArgs[2], weapongFactory.ProduceWeapon(commandArgs[1], commandArgs[2]));
                        break;
                    case "Add":
                        IGem gem = gemFactory.ProduceGem(commandArgs[3]);
                        IWeapon weаpon = weapons[commandArgs[1]];
                        weаpon.InsertGem(gem, int.Parse(commandArgs[2]));
                        break;
                    case "Remove":
                        weаpon = weapons[commandArgs[1]];
                        weаpon.RemoveGem(int.Parse(commandArgs[2]));
                        break;
                    case "Print":
                        weаpon = weapons[commandArgs[1]];
                        weаpon.Print();
                        break;
                }
            }
        }
    }
}

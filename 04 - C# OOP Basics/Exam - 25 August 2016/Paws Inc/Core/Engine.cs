namespace Paws_Inc.Models.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Paws_Inc.Core;

    public class Engine
    {
        private bool isRunning;
        private AnimalService animalService;

        public Engine()
        {
            this.isRunning = false;
            this.animalService = new AnimalService();
        }

        public void Run()
        {
            this.isRunning = true;
            while (this.isRunning)
            {
                string inputLine = this.ReadInput();
                List<string> commandArguments = this.ParseInput(inputLine);
                this.isRunning = this.animalService.ManageCommand(commandArguments);
            }
        }

        private List<string> ParseInput(string inputLine)
        {
            return inputLine
                .Split(new []{'|'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToList();
        }

        private string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}




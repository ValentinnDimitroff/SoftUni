namespace _03BarracksFactory.Core
{
    using System;
    using System.Globalization;
    using Commands;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandsNamespacePath = "_03BarracksFactory.Core.Commands.";
        private const string CommandSuffix = "Command";

        private IUnitFactory unitFactory;
        private IRepository repository;

        public CommandInterpreter(IUnitFactory unitFactory, IRepository repository)
        {
            this.unitFactory = unitFactory;
            this.repository = repository;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string commandFullName =
                CommandsNamespacePath +
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) +
                CommandSuffix;

            object[] commandParameters =
            {
                data,
                repository,
                unitFactory
            };

            IExecutable command;
            try
            {
                command = (Command)Activator.CreateInstance(Type.GetType(commandFullName), commandParameters);
            }
            catch
            {
                throw new InvalidOperationException("Invalid command!");
            }

            return command;
        }
    }
}
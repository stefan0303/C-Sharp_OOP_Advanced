using System;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Engine;
using InfernoInfinity.Interfaces.Factories;
using InfernoInfinity.Models.Commands;
using ICommand = InfernoInfinity.Interfaces.Commands.ICommand;

namespace InfernoInfinity.Factories
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string commandName, IEngine engine)
        {
            ICommand command = null;

            Commands name;

            bool isValidCommandName = System.Enum.TryParse(commandName, out name);

            if (!isValidCommandName)
            {
                throw new ArgumentException("Invalid command name!");
            }

            switch (name)
            {
                   case Commands.Add:
                    command = new AddCommand(engine);
                    break;
                    case Commands.Create:
                    command = new CreateCommand(engine);
                    break;
                    case Commands.Remove:
                    command = new RemoveCommand(engine);
                    break;
                    case Commands.Print:
                    command = new PrintCommand(engine);
                    break;
            }

            return command;
        }
    }
}

using System;
using System.Linq;
using InfernoInfinity.Interfaces.Engine;
using InfernoInfinity.Interfaces.Factories;
using InfernoInfinity.Interfaces.UI;

namespace InfernoInfinity.Engine
{
    public class Engine : IEngine
    {
        private readonly IConsoleRender renderer;
        private readonly IConsoleInputController controller;

        public Engine
            (
            IConsoleRender renderer,
            IConsoleInputController controller,
            ICommandFactory commandFactory,
            IWeaponFactory weaponFactory,
            IGemFactory gemFactory,
            IInventory inventory
            )
        {
            this.renderer = renderer;
            this.controller = controller;
            this.CommandFactory = commandFactory;
            this.WeaponFactory = weaponFactory;
            this.GemFactory = gemFactory;
            this.Inventory = inventory;
        }

        public IWeaponFactory WeaponFactory { get; private set; }
        public ICommandFactory CommandFactory { get; private set; }
        public IGemFactory GemFactory { get; private set; }
        public IInventory Inventory { get; private set; }

        public void Run()
        {
            while (true)
            {
                string input = this.controller.ReadInput();

                if (input == "END")
                {
                    break;
                }

                this.ExecuteCommand(input);
            }
            Console.WriteLine(string.Join("\r\n", this.Inventory.Weapons));
        }

        public void ExecuteCommand(string commandInput)
        {
            string[] commandParam = commandInput.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string commandName = commandParam[0];

            var commandParams = commandParam.Skip(1).ToArray();

            var command = this.CommandFactory.CreateCommand(commandName, this);

            command.Execute(commandParams);
        }

        public void Render(string message, params object[] parameters)
        {
            this.renderer.Print(message, parameters);
        }
    }
}

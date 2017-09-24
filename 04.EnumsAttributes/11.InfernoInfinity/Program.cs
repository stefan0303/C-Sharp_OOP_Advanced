using InfernoInfinity.Engine;
using InfernoInfinity.Factories;
using InfernoInfinity.Factories.GemFactory;
using InfernoInfinity.Factories.Weapo;
using InfernoInfinity.Interfaces.Engine;
using InfernoInfinity.Interfaces.Factories;
using InfernoInfinity.Interfaces.UI;

using InfernoInfinity.UI;

namespace InfernoInfinity
{
    class Program
    {
        static void Main()
        {

            IConsoleInputController inputController = new ConsoleInputController();
            IConsoleRender renderer = new ConsoleRender();

            ICommandFactory commandFactory = new CommandFactory();
            IWeaponFactory weaponFactory = new WeaponFactory();
            IGemFactory gemFactory = new GemFactory();

            IInventory inventory = new Inventory();

            IEngine engine = new Engine.Engine(
                renderer,
                inputController,
                commandFactory,
                weaponFactory,
                gemFactory,
                inventory
                );

            engine.Run();

        }
    }
}

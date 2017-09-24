using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Factories.GemFactory;
using InfernoInfinity.Interfaces.Factories;

namespace InfernoInfinity.Interfaces.Engine
{
    public interface IEngine
    {
        ICommandFactory CommandFactory { get; }
        IWeaponFactory WeaponFactory { get; }
        IGemFactory GemFactory { get; }
        IInventory Inventory { get; }

        void Run();
        void Render(string message, params object[] parameters);
    }
}

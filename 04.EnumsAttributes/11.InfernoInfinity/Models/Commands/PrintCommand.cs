using System;
using System.Linq;
using InfernoInfinity.Interfaces.Engine;

namespace InfernoInfinity.Models.Commands
{
    public class PrintCommand : Command
    {
        public PrintCommand(IEngine engine) : 
            base(engine) { }

        public override void Execute(params string[] commandParams)
        {
            string weaponName = commandParams[0];

            if (!CheckIfWeaponExists(weaponName))
            {
                throw new ArgumentException("No such weapon in inventory");
            }

            var weapon = this.Engine.Inventory.Weapons.FirstOrDefault(w => w.Name == weaponName);

            this.Engine.Render(weapon.ToString(), weapon.Name);
        }

        private bool CheckIfWeaponExists(string weaponName)
        {
            bool ifWeaponExists = this.Engine.Inventory.Weapons.Any(w => w.Name == weaponName);

            return ifWeaponExists;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Engine;

namespace InfernoInfinity.Models.Commands
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(IEngine engine) : 
            base(engine) { }

        public override void Execute(params string[] commandParams)
        {
            string weaponName = commandParams[0];
            int position = int.Parse(commandParams[1]);

            if (!CheckIfWeaponExists(weaponName))
            {
                throw new ArgumentException("No such weapon in inventory");
            }

            var weapon = this.Engine.Inventory.Weapons.FirstOrDefault(w => w.Name == weaponName);
            weapon.RemoveGem(position);
        }

        private bool CheckIfWeaponExists(string weaponName)
        {
            bool ifWeaponExists = this.Engine.Inventory.Weapons.Any(w => w.Name == weaponName);

            return ifWeaponExists;
        }
    }
}

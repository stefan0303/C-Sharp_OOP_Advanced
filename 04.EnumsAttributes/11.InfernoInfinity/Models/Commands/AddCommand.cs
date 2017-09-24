using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Engine;

namespace InfernoInfinity.Models.Commands
{
    public class AddCommand : Command
    {
        public AddCommand(IEngine engine) 
            : base(engine) { }

        public override void Execute(params string[] commandParams)
        {
            string weaponName = commandParams[0];
            int position = int.Parse(commandParams[1]);
            string gemParams = commandParams[2];

            var gem = this.Engine.GemFactory.CreateGem(gemParams);

            if (!CheckIfWeaponExists(weaponName))
            {
                throw new ArgumentException("There is no such weapon!");
            }

            var weapon = this.Engine.Inventory.Weapons.FirstOrDefault(w => w.Name == weaponName);

            weapon.AddGem(gem, position);
        }

        private bool CheckIfWeaponExists(string weaponName)
        {
            bool ifWeaponExists = this.Engine.Inventory.Weapons.Any(w => w.Name == weaponName);

            return ifWeaponExists;
        }
    }
}

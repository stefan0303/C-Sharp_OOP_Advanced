using InfernoInfinity.Interfaces.Engine;
using InfernoInfinity.Interfaces.Weapons;

namespace InfernoInfinity.Models.Commands
{
    public class CreateCommand : Command
    {

        public CreateCommand(IEngine engine) : 
            base (engine) { }

        public override void Execute(params string[] commandParams)
        {
            string weaponParams = commandParams[0];
            string weaponName = commandParams[1];

            IWeapon weapon =  this.Engine.WeaponFactory.CreateWeapon(weaponParams, weaponName);

            this.Engine.Inventory.AddWeapon(weapon);
        }
    }
}

using InfernoInfinity.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Weapons;

namespace InfernoInfinity.Engine
{
    public class Inventory : IInventory
    {
        private List<IWeapon> weapons;

        public Inventory()
        {
            this.Weapons = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.Weapons.Add(weapon);
        }

        public List<IWeapon> Weapons { get; private set; }
    }
}

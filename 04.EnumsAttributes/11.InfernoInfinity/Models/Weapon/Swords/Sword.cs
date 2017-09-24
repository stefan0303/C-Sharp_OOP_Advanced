using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Interfaces.Jewelery;
using InfernoInfinity.Interfaces.Weapons.Swords;
using InfernoInfinity.Models.Jewelery;

namespace InfernoInfinity.Models.Weapon.Swords
{
    public abstract class Sword : Weapon, ISword
    {
        private const int MinimumDamage = 4;
        private const int MaximumDamage = 6;
        private const int Socket = 3;

        public Sword(string name) : 
            base(name, MinimumDamage, MaximumDamage, Socket)
        {
            this.gems = new IGem[Socket];
        }
    }
}

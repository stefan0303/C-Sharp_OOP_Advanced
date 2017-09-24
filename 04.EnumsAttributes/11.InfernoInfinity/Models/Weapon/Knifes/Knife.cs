using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Interfaces.Jewelery;
using InfernoInfinity.Interfaces.Weapons.Knifes;
using InfernoInfinity.Models.Jewelery;

namespace InfernoInfinity.Models.Weapon.Knifes
{
    public abstract class Knife : Weapon, IKnife
    {
        private const int MinimumDamage = 3;
        private const int MaximumDamage = 4;
        private const int Socket = 2;

        public Knife(string name) : 
            base (name, MinimumDamage, MaximumDamage, Socket)
        {
           this.gems = new IGem[Socket]; 
        }
    }
}

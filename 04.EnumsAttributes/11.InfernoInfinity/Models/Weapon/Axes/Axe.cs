using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Interfaces.Weapons.Axes;
using InfernoInfinity.Models.Jewelery;

namespace InfernoInfinity.Models.Weapon.Axes
{
    public abstract class Axe : Weapon, IAxe
    {
        private const int MinimumDamage = 5;
        private const int MaximumDamage = 10;
        private const int Socket = 4;

        public Axe(string name) : 
            base(name, MinimumDamage, MaximumDamage, Socket)
        {
            //this.gems = new List<Gem>(Socket);
        }

    }
}

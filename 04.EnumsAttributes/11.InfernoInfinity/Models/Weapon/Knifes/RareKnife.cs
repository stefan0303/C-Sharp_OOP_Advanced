using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Weapons.Knifes;

namespace InfernoInfinity.Models.Weapon.Knifes
{
    public class RareKnife : Knife, IRareKnife
    {
        public RareKnife(string name) : 
            base(name) { }

        public override int MinDamage
        {
            get { return base.MinDamage; }
            protected set { base.MinDamage = value * (int)Rarity.Rare; }
        }

        public override int MaxDamage
        {
            get { return base.MaxDamage; }
            protected set { base.MaxDamage = value * (int)Rarity.Rare; }
        }
    }
}

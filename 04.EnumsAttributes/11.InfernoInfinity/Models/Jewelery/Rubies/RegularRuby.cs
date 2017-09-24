using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Jewelery.Rubies;

namespace InfernoInfinity.Models.Jewelery.Rubies
{
    public class RegularRuby : Ruby, IRegularRuby
    {
        public RegularRuby() : 
            base() { }

        public override int Strength
        {
            get { return base.Strength; }
            protected set { base.Strength = value + (int)Clarity.Regular; }
        }

        public override int Agility
        {
            get { return base.Agility; }
            protected set { base.Agility = value + (int)Clarity.Regular; }
        }

        public override int Vitality
        {
            get { return base.Vitality; }
            protected set { base.Vitality = value + (int)Clarity.Regular; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Jewelery.Amethysts;

namespace InfernoInfinity.Models.Jewelery.Amethysts
{
    public class PerfectAmethyst : Amethyst, IPerfectAmethyst
    {
        public PerfectAmethyst() : 
            base() { }

        public override int Strength
        {
            get { return base.Strength; }
            protected set { base.Strength = value + (int)Clarity.Perfect; }
        }

        public override int Agility
        {
            get { return base.Agility; }
            protected set { base.Agility = value + (int)Clarity.Perfect; }
        }

        public override int Vitality
        {
            get { return base.Vitality; }
            protected set { base.Vitality = value + (int)Clarity.Perfect; }
        }
    }
}

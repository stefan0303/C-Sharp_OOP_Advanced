using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Jewelery.Amethysts;

namespace InfernoInfinity.Models.Jewelery.Amethysts
{
    public class ChippedAmethyst : Amethyst, IChippedAmethyst
    {
        public ChippedAmethyst() : 
            base() { }

        public override int Strength
        {
            get { return base.Strength; }
            protected set { base.Strength = value + (int)Clarity.Chipped; }
        }

        public override int Agility
        {
            get { return base.Agility; }
            protected set { base.Agility = value + (int)Clarity.Chipped; }
        }

        public override int Vitality
        {
            get { return base.Vitality; }
            protected set { base.Vitality = value + (int)Clarity.Chipped; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Jewelery.Amethysts;

namespace InfernoInfinity.Models.Jewelery.Amethysts
{
    public abstract class Amethyst : Gem, IAmethyst
    {
        private const int Strength = 2;
        private const int Agility = 8;
        private const int Vitality = 4;

        protected Amethyst() :
            base(Strength, Agility, Vitality) { }
    }
}

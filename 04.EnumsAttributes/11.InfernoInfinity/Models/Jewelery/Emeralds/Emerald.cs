using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Jewelery.Emeralds;

namespace InfernoInfinity.Models.Jewelery.Emeralds
{
    public abstract class Emerald : Gem, IEmerald
    {
        private const int Strength = 1;
        private const int Agility = 4;
        private const int Vitality = 9;

        protected Emerald() :
            base(Strength, Agility, Vitality) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Jewelery.Rubies;

namespace InfernoInfinity.Models.Jewelery.Rubies
{
    public abstract class Ruby : Gem, IRuby
    {
        private const int Strength = 7;
        private const int Agility = 2;
        private const int Vitality = 5;    

        protected Ruby() :
            base(Strength, Agility, Vitality) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Interfaces.Jewelery;

namespace InfernoInfinity.Models.Jewelery
{
    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        protected Gem(int strength, int agility, int vitality)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
        }

        public virtual int Strength
        {
            get { return this.strength; }
            protected set { this.strength = value; }
        }

        public virtual int Agility
        {
            get { return this.agility; }
            protected set { this.agility = value; }
        }

        public virtual int Vitality
        {
            get { return this.vitality; }
            protected set { this.vitality = value; }
        }

        
    }
}

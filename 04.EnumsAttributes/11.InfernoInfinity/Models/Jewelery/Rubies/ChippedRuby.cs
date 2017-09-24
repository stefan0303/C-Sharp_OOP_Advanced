﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Jewelery.Rubies;

namespace InfernoInfinity.Models.Jewelery.Rubies
{
    public class ChippedRuby : Ruby, IChippedRuby
    {
        public ChippedRuby() : 
            base() { }

        public override int Strength
        {
            get { return base.Strength; }
            protected set { base.Strength = value + (int) Clarity.Chipped; }
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

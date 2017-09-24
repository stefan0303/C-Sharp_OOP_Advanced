﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Interfaces.Weapons.Axes;

namespace InfernoInfinity.Models.Weapon.Axes
{
    public class EpicAxe : Axe, IEpicAxe
    {
        public EpicAxe(string name) : 
            base(name) { }

        public override int MinDamage
        {
            get { return base.MinDamage; }
            protected set { base.MinDamage = value * (int) Rarity.Epic; }
        }

        public override int MaxDamage
        {
            get { return base.MaxDamage; }
            protected set { base.MaxDamage = value * (int) Rarity.Epic; }
        }
    }
}

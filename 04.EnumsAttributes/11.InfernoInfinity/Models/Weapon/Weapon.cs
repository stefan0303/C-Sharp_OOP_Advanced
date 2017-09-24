using System;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Jewelery;
using InfernoInfinity.Interfaces.Weapons;

namespace InfernoInfinity.Models.Weapon
{
    public abstract class Weapon : IWeapon
    {
        private int minDamage;
        private int maxDamage;

        private int strength;
        private int agility;
        private int vitality;

        private int sockets;

        private string name;

        protected IGem[] gems;

        protected Weapon(string name, int minDamage, int maxDamage, int socket)
        {
            this.Name = name;
            gems = new IGem[socket];
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.Sockets = socket;

            this.Strength = 0;
            this.Agility = 0;
            this.Vitality = 0;
        }

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public virtual int MinDamage
        {
            get { return this.minDamage; }
            protected set { this.minDamage = value; }
        }

        public virtual int MaxDamage
        {
            get { return this.maxDamage; }
            protected set { this.maxDamage = value; }
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

        public int Sockets
        {
            get { return this.sockets; }
            protected set { this.sockets = value; }
        }

        public void AddGem(IGem gem, int position)
        {
            if (position >= 0 && position < this.Sockets)
            {
                if (this.gems[position] != null)
                {
                    this.SwapGems(this.gems[position], gem);
                }

                this.gems[position] = gem;

                this.Strength += gem.Strength;
                this.MinDamage += (int)Multiplyer.StrengthMinDamage * gem.Strength;
                this.MaxDamage += (int)Multiplyer.StrengthMaxDamage * gem.Strength;

                this.Agility += gem.Agility;
                this.MinDamage += (int)Multiplyer.AgilityMinDamage * gem.Agility;
                this.MaxDamage += (int)Multiplyer.AgilityMaxDamage * gem.Agility;

                this.Vitality += gem.Vitality;
            }
        }

        public void RemoveGem(int position)
        {
            if (position >= 0 && position < this.Sockets)
            {
                var gem = this.gems[position];

                this.gems[position] = null;

                this.Strength -= gem.Strength;
                this.MinDamage -= (int)Multiplyer.StrengthMinDamage * gem.Strength;
                this.MaxDamage -= (int)Multiplyer.StrengthMaxDamage * gem.Strength;

                this.Agility -= gem.Agility;
                this.MinDamage -= (int)Multiplyer.AgilityMinDamage * gem.Agility;
                this.MaxDamage -= (int)Multiplyer.AgilityMaxDamage * gem.Agility;

                this.Vitality -= gem.Vitality;
            }           
        }

        private void SwapGems(IGem currentGem, IGem newGem)
        {
            this.Strength -= currentGem.Strength;
            this.MinDamage -= (int)Multiplyer.StrengthMinDamage * currentGem.Strength;
            this.MaxDamage -= (int)Multiplyer.StrengthMaxDamage * currentGem.Strength;

            this.Agility -= currentGem.Agility;
            this.MinDamage -= (int)Multiplyer.AgilityMinDamage * currentGem.Agility;
            this.MaxDamage -= (int)Multiplyer.AgilityMaxDamage * currentGem.Agility;

            this.Vitality -= currentGem.Vitality;

            this.Strength += newGem.Strength;
            this.MinDamage += (int)Multiplyer.StrengthMinDamage * newGem.Strength;
            this.MaxDamage += (int)Multiplyer.StrengthMaxDamage * newGem.Strength;

            this.Agility += newGem.Agility;
            this.MinDamage += (int)Multiplyer.AgilityMinDamage * newGem.Agility;
            this.MaxDamage += (int)Multiplyer.AgilityMaxDamage * newGem.Agility;

            this.Vitality += newGem.Vitality;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}-{2} Damage, +{3} Strength, +{4} Agility, +{5} Vitality",
                this.Name, this.MinDamage, this.MaxDamage, this.Strength, this.Agility, this.Vitality);
        }
    }
}

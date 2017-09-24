using System;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Factories;
using InfernoInfinity.Interfaces.Weapons;
using InfernoInfinity.Models.Weapon.Axes;
using InfernoInfinity.Models.Weapon.Knifes;
using InfernoInfinity.Models.Weapon.Swords;

namespace InfernoInfinity.Factories.Weapo
{
    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(string input, string weaponName)
        {
            IWeapon weapon = null;

            string[] weaponParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Rarity weaponRarity;
            Weapons weaponType;

            bool isValidWeapon = System.Enum.TryParse(weaponParams[1], out weaponType);

            if (!isValidWeapon)
            {
                throw new ArgumentException("Invalid weapon type!");
            }

            bool iValidRarity = System.Enum.TryParse(weaponParams[0], out weaponRarity);

            if (!iValidRarity)
            {
                throw new ArgumentException("Invalid weapon rarity!");
            }

            if (weaponType == Weapons.Axe)
            {
                switch (weaponRarity)
                {
                        case Rarity.Common:
                        weapon = new CommonAxe(weaponName);
                        break;
                        case Rarity.Uncommon:
                        weapon = new UncommonAxe(weaponName);
                        break;
                        case Rarity.Rare:
                        weapon = new RareAxe(weaponName);
                        break;
                        case Rarity.Epic:
                        weapon = new EpicAxe(weaponName);
                        break;
                }
            } else if (weaponType == Weapons.Sword)
            {
                switch (weaponRarity)
                {
                    case Rarity.Common:
                        weapon = new CommonSword(weaponName);
                        break;
                    case Rarity.Uncommon:
                        weapon = new UncommonSword(weaponName);
                        break;
                    case Rarity.Rare:
                        weapon = new RareSword(weaponName);
                        break;
                    case Rarity.Epic:
                        weapon = new EpicSword(weaponName);
                        break;
                }
            } else if (weaponType == Weapons.Knife)
            {
                switch (weaponRarity)
                {
                    case Rarity.Common:
                        weapon = new CommonKnife(weaponName);
                        break;
                    case Rarity.Uncommon:
                        weapon = new UncommonKnife(weaponName);
                        break;
                    case Rarity.Rare:
                        weapon = new RareKnife(weaponName);
                        break;
                    case Rarity.Epic:
                        weapon = new EpicKnife(weaponName);
                        break;
                }
            }
            return weapon;
        }
    }
}

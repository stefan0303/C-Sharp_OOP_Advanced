using InfernoInfinity.Interfaces.Weapons;

namespace InfernoInfinity.Interfaces.Factories
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string input, string weaponName);
    }
}

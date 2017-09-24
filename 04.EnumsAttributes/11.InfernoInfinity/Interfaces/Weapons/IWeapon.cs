using InfernoInfinity.Interfaces.Jewelery;

namespace InfernoInfinity.Interfaces.Weapons
{
    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }
        int MaxDamage { get; }
        int Sockets { get; }
        int Strength { get; }
        int Agility { get; }
        int Vitality { get; }

        void AddGem(IGem gem, int position);
        void RemoveGem(int position);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Weapons;

namespace InfernoInfinity.Interfaces.Engine
{
    public interface IInventory
    {
        void AddWeapon(IWeapon weapon);
        List<IWeapon> Weapons { get; }  
    }
}

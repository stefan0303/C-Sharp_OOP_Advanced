using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Jewelery;

namespace InfernoInfinity.Interfaces.Factories
{
    public interface IGemFactory
    {
        IGem CreateGem(string input);
    }
}

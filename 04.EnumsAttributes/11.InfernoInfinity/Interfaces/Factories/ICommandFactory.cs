using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Interfaces.Commands;
using InfernoInfinity.Interfaces.Engine;

namespace InfernoInfinity.Interfaces.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName, IEngine engine);
    }
}

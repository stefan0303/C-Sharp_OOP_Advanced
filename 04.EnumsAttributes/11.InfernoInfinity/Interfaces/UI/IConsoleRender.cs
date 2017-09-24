using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity.Interfaces.UI
{
    public interface IConsoleRender
    {
        void Print(string message, params object[] parameters);
    }
}

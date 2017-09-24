using System;
using InfernoInfinity.Interfaces.UI;

namespace InfernoInfinity.UI
{
    public class ConsoleRender : IConsoleRender
    {
        public void Print(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}

using System;
using InfernoInfinity.Interfaces.UI;

namespace InfernoInfinity.UI
{
    public class ConsoleInputController : IConsoleInputController
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}

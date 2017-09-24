using InfernoInfinity.Interfaces.Engine;
using ICommand = InfernoInfinity.Interfaces.Commands.ICommand;

namespace InfernoInfinity.Models.Commands
{
    public abstract class Command : ICommand
    {
        protected Command(IEngine engine)
        {
            this.Engine = engine;
        }

        public IEngine Engine { get; private set; }

        public abstract void Execute(params string[] commandParams);
    }
}

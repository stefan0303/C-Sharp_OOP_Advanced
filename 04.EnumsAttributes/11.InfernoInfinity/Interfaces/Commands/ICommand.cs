using InfernoInfinity.Interfaces.Engine;

namespace InfernoInfinity.Interfaces.Commands
{
    public interface ICommand
    {
        IEngine Engine { get; }
        void Execute(params string[] commandParams);
    }
}

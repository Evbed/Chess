using Core.Boards;
using Core.RuleSet;

namespace Core
{
    public interface IGame
    {
        IBoard Board { get; }
        IRules Rules { get; }

        void Run();
    }
}
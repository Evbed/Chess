using Core.Boards;

namespace Core.RuleSet
{
    public interface IRules
    {
        void PlaceOnStartPoses(IBoard board);

        IAvailableMoves AvailableMoves { get; }
    }
}
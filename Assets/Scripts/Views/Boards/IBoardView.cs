using Core.Boards;

namespace Views.Boards
{
    public interface IBoardView
    {
        void Render(IBoard board);
    }
}
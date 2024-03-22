using UnityEngine;

namespace Core.Boards
{
    public interface IBoard
    {
        uint Size { get; }

        Cell Cell(Vector2Int coordinate);

        void Move(Vector2Int from, Vector2Int to);
    }

    public static class BoardExtensions
    {
        public static int SizeAsInt(this IBoard board)
        {
            return (int)board.Size;
        }
    }
}
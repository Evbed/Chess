using System.Collections.Generic;
using System.Linq;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet
{
    public class BoardLimitAvailableMoves : IAvailableMoves
    {
        private readonly IAvailableMoves origin;

        public BoardLimitAvailableMoves(IAvailableMoves origin)
        {
            this.origin = origin;
        }

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board) => origin
            .MovesFor(coordinate, board)
            .Where(m => InsideBoard(board, m))
            .ToList();

        private static bool InsideBoard(IBoard board, Vector2Int coordinate) =>
            coordinate.x < board.Size
            && coordinate.y < board.Size
            && coordinate.x >= 0
            && coordinate.y >= 0;
    }
}
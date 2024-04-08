using System.Collections.Generic;
using Core.Boards;
using Core.RuleSet.Structure;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class QueenAvailableMoves : IAvailableMoves
    {
        private readonly IAvailableMoves availableMoves;

        public QueenAvailableMoves()
        {
            availableMoves = new ObstacleLimitAvailableMoves(
                new SeveralAvailableMoves(
                new BishopAvailableMoves(),
                new RookAvailableMoves()
            ));
        }

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            return availableMoves.MovesFor(coordinate, board);
        }
    }
}
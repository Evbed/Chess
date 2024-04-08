using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class KingAvailableMoves : IAvailableMoves
    {
        private readonly IAvailableMoves availableMoves;

        public KingAvailableMoves()
        {
            availableMoves = new ObstacleLimitAvailableMoves(
                new DistanceLimitAvailableMoves(
                    new QueenAvailableMoves()));
        }
        
        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            return availableMoves.MovesFor(coordinate, board);
        }
    }
}
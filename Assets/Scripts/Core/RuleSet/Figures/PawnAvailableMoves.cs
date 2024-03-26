using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class PawnAvailableMoves : IAvailableMoves
    {
        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            List<Vector2Int> directions = new List<Vector2Int>();

            directions.Add(new Vector2Int(coordinate.x, coordinate.y + 2)); //TODO only for fist move
            directions.Add(new Vector2Int(coordinate.x, coordinate.y + 1));
            
            return directions;
        }
    }
}
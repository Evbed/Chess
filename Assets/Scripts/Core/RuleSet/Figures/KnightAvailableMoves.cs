using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class KnightAvailableMoves : IAvailableMoves
    {
        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            List<Vector2Int> directions = new List<Vector2Int>();
            
            Vector2Int upRight = new Vector2Int(1, 2);
            Vector2Int upLeft = new Vector2Int(-1, 2);
            
            Vector2Int rightUp = new Vector2Int(2, 1);
            Vector2Int rightDown = new Vector2Int(2, -1);
            
            Vector2Int downRight = new Vector2Int(1, -2);
            Vector2Int downLeft = new Vector2Int(-1, -2);
            
            Vector2Int leftUp = new Vector2Int(-2, 1);
            Vector2Int leftDown = new Vector2Int(-2, -1);
            
            directions.Add(upRight);
            directions.Add(upLeft);
            directions.Add(rightUp);
            directions.Add(rightDown);
            directions.Add(downRight);
            directions.Add(downLeft);
            directions.Add(leftUp);
            directions.Add(leftDown);

            return directions;
        }
    }
}
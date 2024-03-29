using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class RookAvailableMoves : IAvailableMoves
    {

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            List<Vector2Int> directions = new List<Vector2Int>();
            var size = board.Size;

            for (int i = 1; i < size; i++)
            {
                var additionalCoordinate = new Vector2Int(0, i);
                var finalCoordinate = additionalCoordinate + coordinate;
                directions.Add(finalCoordinate);
            }
            
            for (int i = 1; i < size; i++)
            {
                var additionalCoordinate = new Vector2Int(0, -i);
                var finalCoordinate = additionalCoordinate + coordinate;
                directions.Add(finalCoordinate);
            }
            
            for (int i = 1; i < size; i++)
            {
                var additionalCoordinate = new Vector2Int(i, 0);
                var finalCoordinate = additionalCoordinate + coordinate;
                directions.Add(finalCoordinate);
            }
            
            for (int i = 1; i < size; i++)
            {
                var additionalCoordinate = new Vector2Int(-i, 0);
                var finalCoordinate = additionalCoordinate + coordinate;
                directions.Add(finalCoordinate);
            }
            return directions;
        }
    }
}
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
            Vector2Int diagonalRight = new Vector2Int(coordinate.x + 1, coordinate.y + 1);
            Vector2Int diagonalLeft = new Vector2Int(coordinate.x -1, coordinate.y + 1);

            if (coordinate.y == 1 || coordinate.y == 6) // start positions
            {
                directions.Add(new Vector2Int(coordinate.x, coordinate.y + 2));
            }
            
            directions.Add(new Vector2Int(coordinate.x, coordinate.y + 1));
            
            if (board.Cell(diagonalRight).Figure() != null)
            {
                directions.Add(diagonalRight);
            }
            
            if (board.Cell(diagonalLeft).Figure() != null)
            {
                directions.Add(diagonalLeft);
            }
            
            return directions;
        }
    }
}
using System.Collections.Generic;
using Core.Boards;
using Core.RuleSet.Structure;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class BishopAvailableMoves : IAvailableMoves
    {
        private readonly IAvailableMoves availableMoves;

        public BishopAvailableMoves()
        {
            availableMoves = new DefaultAvailableMoves(
                (coordinate, board) =>
                {
                    var directions = new List<Vector2Int>();
                    var size = board.Size;

                    for (int i = 1; i < size; i++)
                    {
                        var additionalCoordinate = new Vector2Int(i, i);
                        var finalCoordinate = additionalCoordinate + coordinate;

                        directions.Add(finalCoordinate);
                    }

                    for (int i = 1; i < size; i++)
                    {
                        var additionalCoordinate = new Vector2Int(i, i);
                        var finalCoordinate = additionalCoordinate - coordinate;

                        directions.Add(finalCoordinate);
                    }

                    for (int i = 1; i < size; i++)
                    {
                        var additionalCoordinate = new Vector2Int(i, -i);
                        var finalCoordinate = additionalCoordinate + coordinate;
                        directions.Add(finalCoordinate);
                    }

                    for (int i = 1; i < size; i++)
                    {
                        var additionalCoordinate = new Vector2Int(i, -i);
                        var finalCoordinate = additionalCoordinate - coordinate;
                        directions.Add(finalCoordinate);
                    }

                    return directions;
                }
            );
        }

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            return availableMoves.MovesFor(coordinate, board);
        }
    }
}
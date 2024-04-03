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
            Vector2Int move = new Vector2Int(1, 2);
            directions.AddRange(RotatedAndMirroredMoves(move));
            for (var i = 0; i < directions.Count; i++)
            {
                directions[i] += coordinate;
            }

            return directions;
        }

        private static IReadOnlyCollection<Vector2Int> RotatedAndMirroredMoves(in Vector2Int move)
        {
            var list = new List<Vector2Int>();

            static Vector2Int Rotated90(Vector2Int vector)
            {
                return new Vector2Int(-vector.y, vector.x);
            }

            void AddRotated(Vector2Int currentVector)
            {
                for (var i = 0; i < 4; i++)
                {
                    currentVector = Rotated90(currentVector);
                    list!.Add(currentVector);
                }
            }

            var mirrored = new Vector2Int(-move.x, move.y);
            AddRotated(move);
            AddRotated(mirrored);

            return list;
        }
    }
}
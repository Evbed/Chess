using System.Collections.Generic;
using System.Linq;
using Core.Boards;
using Core.RuleSet;
using Core.RuleSet.Figures;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class KnightAvailableMovesTest
    {
        private readonly IReadOnlyDictionary<Vector2Int, IReadOnlyCollection<Vector2Int>> possibleMovesFrom =
            new Dictionary<Vector2Int, IReadOnlyCollection<Vector2Int>>
            {
                [Vector2Int.zero] = new[]
                {
                    new Vector2Int(2, 1),
                    new Vector2Int(1, 2)
                },
                [new Vector2Int(3, 3)] = new[]
                {
                    new Vector2Int(2, 1),
                    new Vector2Int(1, 2),
                    new Vector2Int(1, 4),
                    new Vector2Int(2, 5),
                    new Vector2Int(4, 5),
                    new Vector2Int(5, 4),
                    new Vector2Int(5, 2),
                    new Vector2Int(4, 1)
                }
            };

        [Test]
        public void KnightTest()
        {
            IBoard board = new Board();
            var rookAvailableMoves = new BoardLimitAvailableMoves(new KnightAvailableMoves());

            foreach (var keyValuePair in possibleMovesFrom)
            {
                var moves = rookAvailableMoves.MovesFor(keyValuePair.Key, board).ToList();
                moves.Sort(ComparerVector2Int.Instance);

                var expectedMoves = keyValuePair.Value!.ToList();
                expectedMoves.Sort(ComparerVector2Int.Instance);
                
                Assert.AreEqual(expectedMoves.Count, moves.Count);
                for (var i = 0; i < moves.Count; i++)
                {
                    Assert.AreEqual(expectedMoves[i], moves[i]);
                }
            }
        }

        private class ComparerVector2Int : IComparer<Vector2Int>
        {
            public static readonly ComparerVector2Int Instance = new ComparerVector2Int();

            public int Compare(Vector2Int x, Vector2Int y)
            {
                var xComparison = x.x.CompareTo(y.x);
                if (xComparison != 0) return xComparison;
                var yComparison = x.y.CompareTo(y.y);
                if (yComparison != 0) return yComparison;
                var magnitudeComparison = x.magnitude.CompareTo(y.magnitude);
                if (magnitudeComparison != 0) return magnitudeComparison;
                return x.sqrMagnitude.CompareTo(y.sqrMagnitude);
            }
        }
    }
}
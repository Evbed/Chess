using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class BishopAvailableMoves : IAvailableMoves
    {

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Structure
{
    public class SeveralAvailableMoves : IAvailableMoves
    {
        private readonly IReadOnlyCollection<IAvailableMoves> collection;

        public SeveralAvailableMoves(params IAvailableMoves[] collection) : this(
            collection as IReadOnlyCollection<IAvailableMoves>
        )
        {
        }

        public SeveralAvailableMoves(IReadOnlyCollection<IAvailableMoves> collection)
        {
            this.collection = collection;
        }

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            var list = new List<Vector2Int>();
            foreach (var availableMoves in collection)
            {
                list.AddRange(availableMoves.MovesFor(coordinate, board));
            }

            return list;
        }
    }
}
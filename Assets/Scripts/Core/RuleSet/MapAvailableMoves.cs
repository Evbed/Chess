using System;
using System.Collections.Generic;
using Core.Boards;
using Core.Figures;
using UnityEngine;

namespace Core.RuleSet
{
    public class MapAvailableMoves : IAvailableMoves
    {
        private readonly IReadOnlyDictionary<FigureType, IAvailableMoves> map;

        public MapAvailableMoves(IReadOnlyDictionary<FigureType, IAvailableMoves> map)
        {
            this.map = map;
        }

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            var cell = board.Cell(coordinate);
            var figure = cell.Figure();

            if (figure == null)
            {
                return Array.Empty<Vector2Int>();
            }

            if (map.TryGetValue(figure.Type, out var moves))
            {
                return moves!.MovesFor(coordinate, board);
            }

            throw new Exception($"Figure type is not supported: {figure.Type}");
        }
    }
}
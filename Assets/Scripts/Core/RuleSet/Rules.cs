using System.Collections.Generic;
using Core.Boards;
using Core.Figures;
using UnityEngine;

namespace Core.RuleSet
{
    public class Rules : IRules
    {
        public IAvailableMoves AvailableMoves { get; }

        public Rules(IAvailableMoves availableMoves)
        {
            AvailableMoves = availableMoves;
        }

        public void PlaceOnStartPoses(IBoard board)
        {
            foreach (var pair in whites)
            {
                Debug.Log("White figure " + pair.Value + " placed to " + pair.Key);
                var cell = board.Cell(pair.Key);
                cell.PutFigure(new Figure(FigureColor.White, pair.Value));
            }

            foreach (var pair in blacks)
            {
                Debug.Log("Black figure " + pair.Value + " placed to " + pair.Key);
                var cell = board.Cell(pair.Key);
                cell.PutFigure(new Figure(FigureColor.White, pair.Value));
            }
        }

        private readonly IReadOnlyDictionary<Vector2Int, FigureType> whites = new Dictionary<Vector2Int, FigureType>
        {
            { new Vector2Int(0, 0), FigureType.Rook },
            { new Vector2Int(1, 0), FigureType.Knight },
            { new Vector2Int(2, 0), FigureType.Bishop },
            { new Vector2Int(3, 0), FigureType.King },
            { new Vector2Int(4, 0), FigureType.Queen },
            { new Vector2Int(5, 0), FigureType.Bishop },
            { new Vector2Int(6, 0), FigureType.Knight },
            { new Vector2Int(7, 0), FigureType.Rook },
            { new Vector2Int(0, 1), FigureType.Pawn },
            { new Vector2Int(1, 1), FigureType.Pawn },
            { new Vector2Int(2, 1), FigureType.Pawn },
            { new Vector2Int(3, 1), FigureType.Pawn },
            { new Vector2Int(4, 1), FigureType.Pawn },
            { new Vector2Int(5, 1), FigureType.Pawn },
            { new Vector2Int(6, 1), FigureType.Pawn },
            { new Vector2Int(7, 1), FigureType.Pawn }
        };

        private readonly IReadOnlyDictionary<Vector2Int, FigureType> blacks = new Dictionary<Vector2Int, FigureType>
        {
            { new Vector2Int(0, 7), FigureType.Rook },
            { new Vector2Int(1, 7), FigureType.Knight },
            { new Vector2Int(2, 7), FigureType.Bishop },
            { new Vector2Int(3, 7), FigureType.King },
            { new Vector2Int(4, 7), FigureType.Queen },
            { new Vector2Int(5, 7), FigureType.Bishop },
            { new Vector2Int(6, 7), FigureType.Knight },
            { new Vector2Int(7, 7), FigureType.Rook },
            { new Vector2Int(0, 6), FigureType.Pawn },
            { new Vector2Int(1, 6), FigureType.Pawn },
            { new Vector2Int(2, 6), FigureType.Pawn },
            { new Vector2Int(3, 6), FigureType.Pawn },
            { new Vector2Int(4, 6), FigureType.Pawn },
            { new Vector2Int(5, 6), FigureType.Pawn },
            { new Vector2Int(6, 6), FigureType.Pawn },
            { new Vector2Int(7, 6), FigureType.Pawn },
        };

        public List<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            return new List<Vector2Int>();
        }
    }
}
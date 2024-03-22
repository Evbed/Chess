using System.Collections.Generic;
using Boards;
using Figures;
using UnityEngine;
namespace Rules
{
    public class Rules : IAvailableMoves
    {
        public bool IsPossibleMove(Board board, Vector2 from, Vector2 to)
        {
            return true;
        }

        public IReadOnlyDictionary<Vector2Int, FigureType> Whites = new Dictionary<Vector2Int, FigureType>()
        {
            {new Vector2Int(0,0), FigureType.Rook},
            {new Vector2Int(1,0), FigureType.Knight},
            {new Vector2Int(2,0), FigureType.Bishop},
            {new Vector2Int(3,0), FigureType.King},
            {new Vector2Int(4,0), FigureType.Queen},
            {new Vector2Int(5,0), FigureType.Bishop},
            {new Vector2Int(6,0), FigureType.Knight},
            {new Vector2Int(7,0), FigureType.Rook},
            {new Vector2Int(0,1), FigureType.Pawn},
            {new Vector2Int(1,1), FigureType.Pawn},
            {new Vector2Int(2,1), FigureType.Pawn},
            {new Vector2Int(3,1), FigureType.Pawn},
            {new Vector2Int(4,1), FigureType.Pawn},
            {new Vector2Int(5,1), FigureType.Pawn},
            {new Vector2Int(6,1), FigureType.Pawn},
            {new Vector2Int(7,1), FigureType.Pawn}
        };
    
        public IReadOnlyDictionary<Vector2Int, FigureType> Blacks = new Dictionary<Vector2Int, FigureType>()
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

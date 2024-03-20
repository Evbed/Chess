using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Rules
{
    public bool IsPossibleMove(Board board, Vector2 from, Vector2 to)
    {
        return true;
    }

    public IReadOnlyDictionary<Vector2, FigureType> Whites = new Dictionary<Vector2, FigureType>()
    {
        {new Vector2(0,0), FigureType.Rook},
        {new Vector2(1,0), FigureType.Knight},
        {new Vector2(2,0), FigureType.Bishop},
        {new Vector2(3,0), FigureType.King},
        {new Vector2(4,0), FigureType.Queen},
        {new Vector2(5,0), FigureType.Bishop},
        {new Vector2(6,0), FigureType.Knight},
        {new Vector2(7,0), FigureType.Rook},
        {new Vector2(0,1), FigureType.Pawn},
        {new Vector2(1,1), FigureType.Pawn},
        {new Vector2(2,1), FigureType.Pawn},
        {new Vector2(3,1), FigureType.Pawn},
        {new Vector2(4,1), FigureType.Pawn},
        {new Vector2(5,1), FigureType.Pawn},
        {new Vector2(6,1), FigureType.Pawn},
        {new Vector2(7,1), FigureType.Pawn}
    };
    
    public IReadOnlyDictionary<Vector2, FigureType> Blacks = new Dictionary<Vector2, FigureType>()
    {
        { new Vector2(0, 7), FigureType.Rook },
        { new Vector2(1, 7), FigureType.Knight },
        { new Vector2(2, 7), FigureType.Bishop },
        { new Vector2(3, 7), FigureType.King },
        { new Vector2(4, 7), FigureType.Queen },
        { new Vector2(5, 7), FigureType.Bishop },
        { new Vector2(6, 7), FigureType.Knight },
        { new Vector2(7, 7), FigureType.Rook },
        { new Vector2(0, 6), FigureType.Pawn },
        { new Vector2(1, 6), FigureType.Pawn },
        { new Vector2(2, 6), FigureType.Pawn },
        { new Vector2(3, 6), FigureType.Pawn },
        { new Vector2(4, 6), FigureType.Pawn },
        { new Vector2(5, 6), FigureType.Pawn },
        { new Vector2(6, 6), FigureType.Pawn },
        { new Vector2(7, 6), FigureType.Pawn },
    };
}

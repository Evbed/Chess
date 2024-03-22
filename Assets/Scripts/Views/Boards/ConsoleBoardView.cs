using System;
using System.Text;
using Core.Boards;
using Core.Figures;
using UnityEngine;

namespace Views.Boards
{
    public class ConsoleBoardView : IBoardView
    {
        private readonly Action<string> log;

        public ConsoleBoardView(Action<string> log)
        {
            this.log = log;
        }

        public void Render(IBoard board)
        {
            var sb = new StringBuilder(board.SizeAsInt() * board.SizeAsInt());

            for (var i = 0; i < board.Size; i++)
            {
                for (var j = 0; j < board.Size; j++)
                {
                    var cell = board.Cell(new Vector2Int(j, i));
                    var asString = AsString(cell);
                    sb.Append(asString);
                }

                sb.AppendLine();
            }

            log(sb.ToString());
        }

        private static string AsString(Cell cell)
        {
            return AsString(cell.Figure()?.Type);
        }

        private static string AsString(FigureType? figureType) => figureType switch
        {
            FigureType.Pawn => "P",
            FigureType.Rook => "R",
            FigureType.Knight => "N",
            FigureType.Bishop => "B",
            FigureType.Queen => "Q",
            FigureType.King => "K",
            _ => "_"
        };
    }
}
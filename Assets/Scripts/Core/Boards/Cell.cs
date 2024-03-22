#nullable enable

using System;
using Core.Figures;

namespace Core.Boards
{
    public class Cell
    {
        private Figure? figure;

        public void PutFigure(Figure figure)
        {
            if (this.figure != null)
            {
                throw new Exception("Cell is already occupied");
            }

            this.figure = figure;
        }

        public void ClearFigure()
        {
            figure = null;
        }

        public Figure? Figure()
        {
            return figure;
        }
    }
}
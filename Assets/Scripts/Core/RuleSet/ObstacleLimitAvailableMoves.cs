using System.Collections.Generic;
using System.Linq;
using Core.Boards;
using Core.Figures;
using UnityEngine;

namespace Core.RuleSet
{
    public class ObstacleLimitAvailableMoves : IAvailableMoves
    {
        private readonly IAvailableMoves origin;
        private readonly IReadOnlyCollection<FigureType> ignoreFigures;

        public ObstacleLimitAvailableMoves(IAvailableMoves origin, IReadOnlyCollection<FigureType> ignoreFigures)
        {
            this.origin = origin;
            this.ignoreFigures = ignoreFigures;
        }

        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            var figure = board.Cell(coordinate).Figure();

            if (figure == null)
            {
                throw new System.Exception("No figure on the cell");
            }

            var originMoves = origin.MovesFor(coordinate, board);

            if (ignoreFigures.Contains(figure.Type))
            {
                return originMoves;
            }

            return originMoves
                .Where(m => HasObstacle(m, coordinate, board))
                .ToList();
        }

        private bool HasObstacle(Vector2Int coordinate, Vector2Int targetCoordinate, IBoard board)
        {
            for (int x = coordinate.x; x <= targetCoordinate.x; x++)
            {
                for (int y = coordinate.y; y <= targetCoordinate.y; y++)
                {
                    Vector2Int currentCell = new Vector2Int(x, y);
                    var currentFigure = board.Cell(currentCell).Figure();
                    if (currentFigure == null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
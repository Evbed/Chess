using System.Collections.Generic;
using System.Linq;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet
{
	public class ObstacleLimitAvailableMoves : IAvailableMoves
	{
		private readonly IAvailableMoves origin;

		public ObstacleLimitAvailableMoves(IAvailableMoves origin)
		{
			this.origin = origin;
		}
		
		public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
		{
			return origin.MovesFor(coordinate, board).Where(m =>
				HasObstacle(m, coordinate, board)).ToList();
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

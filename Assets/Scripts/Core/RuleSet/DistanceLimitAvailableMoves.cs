using System.Collections.Generic;
using System.Linq;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet
{
	public class DistanceLimitAvailableMoves : IAvailableMoves
	{
		private readonly IAvailableMoves origin;
		
		public DistanceLimitAvailableMoves(IAvailableMoves origin)
		{
			this.origin = origin;
		}
		
		public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
		{
			return origin.MovesFor(coordinate, board).Where(m =>
				InsideRange(m, coordinate)).ToList();
		}

		private bool InsideRange(Vector2Int coordinate, Vector2Int targetCoordinate)
		{
			return (targetCoordinate - coordinate).magnitude <= Vector2Int.one.magnitude;
		}
	}
}

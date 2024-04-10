using System;
using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Structure
{
	public class DefaultAvailableMoves : IAvailableMoves
	{
		private readonly Func<Vector2Int, IBoard, IReadOnlyCollection<Vector2Int>> func;

		public DefaultAvailableMoves(Func<Vector2Int, IBoard, IReadOnlyCollection<Vector2Int>> func)
		{
			this.func = func;
		}
		
		
		public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
		{
			return func(coordinate, board);
		}
	}
}

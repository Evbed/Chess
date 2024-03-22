using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet
{
	public interface IAvailableMoves
	{
		IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board);
	}
}
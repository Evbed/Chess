using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
	public interface IAvailableMoves
	{
		List<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board);
	}
}

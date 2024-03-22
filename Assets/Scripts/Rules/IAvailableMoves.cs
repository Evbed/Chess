using System.Collections.Generic;
using Boards;
using UnityEngine;
public interface IAvailableMoves
{
	List<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board);
}
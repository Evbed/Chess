using System.Collections.Generic;
using Figures;
using UnityEngine;
namespace Boards
{
	public class Board : IBoard
	{
		private Cell[,] _cells;
		private List<Figure> figures;
    
		public Cell GetCell(int x, int y)
		{
			return _cells[x, y];
		}

		public void Move(Vector2 from, Vector2 to)
		{
	    
		}
	}
}

using Core.Boards;
using Core.RuleSet.Figures;
using UnityEngine;

namespace Tests
{
	public class BishopAvailableMovesTest
	{
		[NUnit.Framework.Test]
		public void BishopAvailableMovesTestSimplePasses()
		{
			IBoard board = new Board();
			var bishopAvailableMoves = new BishopAvailableMoves();
			var moves = bishopAvailableMoves.MovesFor(Vector2Int.one*3, board);
		
			Debug.Log(string.Join(",", moves));
			//Assert.Null(new object());
		}
	}
}

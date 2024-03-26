using Core.Boards;
using Core.RuleSet.Figures;
using UnityEngine;

namespace Tests
{
	public class PawnAvailableMovesTest
	{
		[NUnit.Framework.Test]
		public void PawnAvailableMovesTestSimplePasses()
		{
			IBoard board = new Board();
			var pawnAvailableMoves = new PawnAvailableMoves();
			var moves = pawnAvailableMoves.MovesFor(Vector2Int.one*4, board);
		
			Debug.Log(string.Join(",", moves));
		}
	}
}

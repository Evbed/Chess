using Core.Boards;
using Core.RuleSet.Figures;
using UnityEngine;

namespace Tests
{
	public class RookAvalablemovesTest
	{
		[NUnit.Framework.Test]
		public void RookAvailableMovesTestSimplePasses()
		{
			IBoard board = new Board();
			var rookAvailableMoves = new RookAvailableMoves();
			var moves = rookAvailableMoves.MovesFor(Vector2Int.zero, board);
			
			Debug.Log(string.Join(",", moves));

		}
	}
}

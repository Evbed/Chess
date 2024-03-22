using Core;
using Core.Players;
using UnityEngine;
using Views.Boards;

public class EntryPoint : MonoBehaviour
{
    private void Start()
    {
        IGame game = new Game(new Player(), new Player());
        IBoardView boardView = new ConsoleBoardView(Debug.Log);

        game.Run();
        boardView.Render(game.Board);
    }
}
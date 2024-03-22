using System.Collections.Generic;
using Core.Boards;
using Core.Figures;
using Core.Players;
using Core.RuleSet;
using Core.RuleSet.Figures;

namespace Core
{
    public class Game : IGame
    {
        private readonly IPlayer[] players;

        public IBoard Board { get; }

        public IRules Rules { get; }

        public Game(IPlayer white, IPlayer black) : this(new[] { white, black })
        {
        }

        public Game(IPlayer[] players) : this(
            new Board(),
            new Rules(
                new MapAvailableMoves(
                    new Dictionary<FigureType, IAvailableMoves>
                    {
                        [FigureType.Pawn] = new PawnAvailableMoves(),
                        [FigureType.Rook] = new RookAvailableMoves(),
                        [FigureType.Knight] = new KnightAvailableMoves(),
                        [FigureType.Bishop] = new BishopAvailableMoves(),
                        [FigureType.Queen] = new QueenAvailableMoves(),
                        [FigureType.King] = new KingAvailableMoves()
                    }
                )
            ),
            players
        )
        {
        }

        public Game(IBoard board, IRules rules, IPlayer[] players)
        {
            this.Board = board;
            this.Rules = rules;
            this.players = players;
        }

        public void Run()
        {
            Rules.PlaceOnStartPoses(Board);
            // foreach (var player in players)
            // {
            //     player.AskMove();//TODO
            // }
            
            //throw new System.NotImplementedException();
        }

    }
}
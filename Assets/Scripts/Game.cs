using System.Collections.Generic;
using Boards;
using Figures;
using Players;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Board _board;
    private Player[] _players;
    private List<Figure> _figures;
    
    private void Start()
    {
        Run();
    }

    private void Run()
    {
        Rules.Rules rules = new Rules.Rules();
        
        foreach (var pair in rules.Whites)
        {
            Debug.Log("White figure " + pair.Value + " placed to " + pair.Key);
            _figures.Add(new Figure(FigureColor.White, pair.Value, pair.Key));
        }
        
        foreach (var pair in rules.Blacks)
        {
            Debug.Log("Black figure " + pair.Value + " placed to " + pair.Key);
            _figures.Add(new Figure(FigureColor.Black, pair.Value, pair.Key));
        }
    }
}

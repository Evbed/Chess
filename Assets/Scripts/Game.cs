using DefaultNamespace;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Board _board;
    private Player[] _players;

    private void Start()
    {
        Run();
    }

    private void Run()
    {
        Rules rules = new Rules();
        
        foreach (var pair in rules.Whites)
        {
            Debug.Log("White figure " + pair.Value + " placed to " + pair.Key);
        }
        
        foreach (var pair in rules.Blacks)
        {
            Debug.Log("Black figure " + pair.Value + " placed to " + pair.Key);
        }
    }
    
    
}

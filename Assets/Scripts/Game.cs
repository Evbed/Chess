using DefaultNamespace;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Board _board;
    private Player[] _players;
    [SerializeField ]private Figure[] figures;

    private void Start()
    {
        Run();
    }

    public void Run()
    {
        foreach (Figure f in figures)
        {
            f.Init();
        }
    }
    
    
}

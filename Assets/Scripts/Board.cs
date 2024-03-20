using UnityEngine;

public class Board : MonoBehaviour
{
    private Cell[,] _cells;
    
    public Cell GetCell(int x, int y)
    {
	    return _cells[x, y];
    }

    public void Move(Vector2 from, Vector2 to)
    {
	    
    }
}

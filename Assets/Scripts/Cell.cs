using UnityEngine;

public class Cell : MonoBehaviour
{
    private Figure _figure;

    public void SetFigure(Figure figure)
    {
        _figure = figure;
    }

    public Figure TryGetFigure()
    {
        if (_figure == null)
        {
            return null;
        }
        return _figure;
    }
}

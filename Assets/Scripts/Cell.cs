using DefaultNamespace;
using JetBrains.Annotations;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private Figure _figure;

    public void SetFigure(Figure figure)
    {
        _figure = figure;
    }

    public void ClearFigure()
    {
        _figure = null;
    }

    [CanBeNull]
    public Figure GetFigureOrNull()
    {
        return _figure;
    }
}

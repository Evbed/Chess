using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Figure : MonoBehaviour
{
    private FigureColor _color;
    private FigureType _type;

    public Figure(FigureColor color, FigureType type)
    {
        _color = color;
        _type = type;
    }
}

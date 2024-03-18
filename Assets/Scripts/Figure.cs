using DefaultNamespace;
using UnityEngine;

public class Figure : MonoBehaviour
{
	[SerializeField] private FigureColor color;
	[SerializeField] private FigureType type;
	[SerializeField] private Vector2Int startPosition;

	public void Init()
	{
		transform.position = new Vector3(startPosition.x, 0,startPosition.y) * 1.5f;
	}

	public FigureColor GetColor()
	{
		return color;
	}

	public FigureType GetType()
	{
		return type;
	}
}

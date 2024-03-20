using UnityEngine;

namespace DefaultNamespace
{
	public class Figure
	{
		private FigureColor _color;
		private FigureType _type;
		private Vector2Int _position;

		public Figure (FigureColor color, FigureType type, Vector2Int position)
		{
			_color = color;
			_type = type;
			_position = position;
		}

		public FigureType GetType()
		{
			return _type;
		}

		public FigureColor GetColor()
		{
			return _color;
		}

		public Vector2Int GetPosition()
		{
			return _position;
		}
	}
}

using UnityEngine;
namespace Figures
{
	public class FigureView : MonoBehaviour
	{
		[SerializeField] private FigureColor color;
		[SerializeField] private FigureType type;

		public void Init()
		{
			//transform.position = new Vector3(startPosition.x, 0,startPosition.y) * 1.5f;
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
}

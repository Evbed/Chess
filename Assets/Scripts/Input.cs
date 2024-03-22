using UnityEngine;
using UnityEngine.EventSystems;
public class Input : IPointerDownHandler, IPointerUpHandler, IDragHandler
{
	public void OnPointerDown(PointerEventData eventData)
	{
		Ray ray = Camera.main.ScreenPointToRay(eventData.position); 

		if (Physics.Raycast(ray, out RaycastHit hit))
		{
			Debug.Log(hit.collider.gameObject.name);
		}
	}
		
	public void OnPointerUp(PointerEventData eventData)
	{
			
	}
		
	public void OnDrag(PointerEventData eventData)
	{
			
	}
}
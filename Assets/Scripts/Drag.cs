using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Drag : MonoBehaviour {
	private Vector3 positionBeforeDragging;
	private LayerMask layermask;

	void OnMouseDown() {
		positionBeforeDragging = new Vector3(transform.position.x, transform.position.y, 10);
	}
	
	void OnMouseDrag()
	{
		Vector3 cursorPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 10);
		transform.position = cursorPosition;
	}

	void OnMouseUp()
	{
		if(GetComponent<Building>().collidingBuildingNumber > 0)
		{
			transform.position = positionBeforeDragging;
		}
		else
		{
			gameObject.GetComponent<Building>().adjustPosition();
		}
		GetComponent<Building>().showPopUp();
	}
}
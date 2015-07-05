using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CameraScript : MonoBehaviour {

	public GameObject movingBuilding;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*if(Input.GetButtonDown("Fire1"))
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(cursorPosition, Vector2.zero);
			
			if(hit.collider != null && hit.collider.tag == ("commonBuilding"))
			{
				// if no building is selected
				if(movingBuilding == null)
				{
					movingBuilding = hit.collider.gameObject;
				}
				// if selected building is clicked again
				else if(movingBuilding != null)
				{
					// if there is colliding building with selected building
					if(movingBuilding.GetComponent<Building>().collidingBuildingNumber > 0)
					{
						Debug.Log("You can not build this location");
					}
					else
					{
						//movingBuilding.GetComponent<CommonBuilding>().adjustPosition();
						movingBuilding = null;
					}
				}
			}
			else if(hit.collider != null && hit.collider.tag == ("uniqueBuilding"))
			{
				// if no building is selected
				if(movingBuilding == null)
				{
					movingBuilding = hit.collider.gameObject;
				}
				// if selected building is clicked again
				else if(movingBuilding != null)
				{
					// if there is colliding building with selected building
					if(movingBuilding.GetComponent<Building>().collidingBuildingNumber > 0)
					{
						Debug.Log("You can not build this location");
					}
					else
					{
						//movingBuilding.GetComponent<UniqueBuilding>().adjustPosition();
						movingBuilding = null;
					}
				}
			}
		}

		if(Input.GetButtonDown ("Fire2"))
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(cursorPosition, Vector2.zero);
			
			if(hit.collider != null && hit.collider.tag == ("commonBuilding"))
			{
				hit.collider.GetComponent<CommonBuilding>().showPopUp();
			}
			else if(hit.collider != null && hit.collider.tag == ("uniqueBuilding"))
			{
				hit.collider.GetComponent<UniqueBuilding>().showPopUp();
			}
		}

		if(movingBuilding != null)
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			movingBuilding.GetComponent<Transform>().position = cursorPosition;
		}*/
	}
}

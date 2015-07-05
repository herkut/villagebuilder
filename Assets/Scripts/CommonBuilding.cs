using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CommonBuilding : Building {

	// Update is called once per frame
	void FixedUpdate () {
		//adjustPosition();
		clearCollidingTiles();
	}
	
	public override void adjustPosition()
	{
		float closestDistance = 20;
		Vector3 closestPosition = buildingTransform.position;
		Vector3 buildingPosition = buildingTransform.position;

		for(int i = 0; i < collidingTiles.Count; i++)
		{
			float distance = Vector3.Distance(buildingPosition, collidingTiles[i]);
			if(distance < closestDistance)
			{
				closestDistance = distance;
				closestPosition = collidingTiles[i];
			}
		}
		buildingTransform.position = closestPosition;
	}

	public override void showPopUp()
	{
		Debug.Log ("Common Building");
	}
}

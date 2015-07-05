using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UniqueBuilding : Building {

	public int type;

	// Update is called once per frame
	void FixedUpdate () {
		//adjustPosition();
		//printCollidingTiles();
		clearCollidingTiles();
	}

	public override void adjustPosition()
	{
		List<Vector3> possiblePositions = createSquares();
		float closestDistance = 20;
		Vector3 closestPosition = buildingTransform.position;
		Vector3 buildingPosition = buildingTransform.position;
		
		for(int i = 0; i < possiblePositions.Count; i++)
		{
			float distance = Vector3.Distance(buildingPosition, possiblePositions[i]);
			if(distance < closestDistance)
			{
				closestDistance = distance;
				closestPosition = possiblePositions[i];
			}
		}
		buildingTransform.position = closestPosition;
	}
	
	public override void showPopUp()
	{
		Debug.Log ("Unique Building no: " + type);
	}

	private List<Vector3> createSquares()
	{
		List<Vector3> result = new List<Vector3>();
		for(int i = 0; i < collidingTiles.Count; i++)
		{
			int k = 0;
			Vector3[] square = new Vector3[4];
			for(int j = 0; j < collidingTiles.Count; j++)
			{
				if(collidingTiles[i].x - collidingTiles[j].x <= 1.5 && collidingTiles[i].x - collidingTiles[j].x > -1.5 
				    && collidingTiles[i].y - collidingTiles[j].y <= 1.5 && collidingTiles[i].y - collidingTiles[j].y > -1.5)
				{
					square[k] = collidingTiles[j];
					k++;
				}
			}
			float x = 0;
			float y = 0;
			for(int j = 0; j < 4; j++)
			{
				x += square[j].x;
				y += square[j].y;
			}
			Vector3 pos = new Vector3(x / 4, y / 4, 10);
			result.Add(pos);
		}
		return result;
	}
}

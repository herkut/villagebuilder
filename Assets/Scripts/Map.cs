using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.tag == "commonBuilding")
		{
			CommonBuilding cb = other.GetComponent<CommonBuilding>();
			Vector3 pos = GetComponent<Transform>().position;
			cb.addCollidingTile(pos);
		}
		else if(other.tag == "uniqueBuilding")
		{
			UniqueBuilding ub = other.GetComponent<UniqueBuilding>();
			Vector3 pos = GetComponent<Transform>().position;
			ub.addCollidingTile(pos);
		}
	}
}

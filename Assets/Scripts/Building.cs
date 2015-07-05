using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Building : MonoBehaviour {

	protected BoxCollider2D boxcollider;
	protected Rigidbody2D rb2dD;
	protected Transform buildingTransform;
	protected List<Vector3> collidingTiles;// used for storing map tile that would be used to adjust building position
	protected bool isDragging;
	protected Vector2 positionBeforeDragging;
	protected Vector3 currentPosition;

	public int collidingBuildingNumber;
	
	public abstract void adjustPosition();
	public abstract void showPopUp();

	// Use this for initialization
	protected virtual void Awake () {
		collidingTiles = new List<Vector3>();
		boxcollider = GetComponent<BoxCollider2D>();
		rb2dD = GetComponent<Rigidbody2D>();
		buildingTransform = GetComponent<Transform>();
		adjustPosition();
	}

	protected virtual void Start()
	{
		adjustPosition();
	}
			
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "uniqueBuilding")
		{
			collidingBuildingNumber++;
		}
		else if(other.tag == "commonBuilding")
		{
			collidingBuildingNumber++;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.tag == "uniqueBuilding")
		{
			collidingBuildingNumber--;
		}
		else if(other.tag == "commonBuilding")
		{
			collidingBuildingNumber--;
		}
	}
	
	public void addCollidingTile(Vector3 transform)
	{
		if(!collidingTiles.Contains(transform))
		{
			collidingTiles.Add(transform);
		}

	}
	
	protected void clearCollidingTiles()
	{
		collidingTiles.Clear();
	}

	protected List<Vector3> getCollidingTiles()
	{
		return collidingTiles;
	}
	
	protected void printCollidingTiles()
	{
		Debug.Log(collidingTiles.Count);
		foreach(Vector3 x in collidingTiles)
		{
			Debug.Log ("Ov yea" + x);
		}
	}
}

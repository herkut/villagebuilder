using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameController : MonoBehaviour {

	void Awake(){
		load();
	}

	void OnApplicationQuit(){
		save();
	}

	public void save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.OpenOrCreate);

		file.Close();
	}

	public void load()
	{
		if(File.Exists(Application.persistentDataPath + "/gameInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);

			file.Close();
		}
	}

	public void quit()
	{
		Application.Quit();
	}
}

[System.Serializable]
class GameData
{
	public List<BuildingData> buildings;
}

[System.Serializable]
class BuildingData
{
	public float x;
	public float y;
	public string name;
}
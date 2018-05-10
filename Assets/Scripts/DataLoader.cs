using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataLoader {


	static string filePath = Application.dataPath + "/GameData/championData.json";

	//it's static so we can call it from anywhere
	public static void Save(List<championsInfo> jsonList) {

		string jsonToSave="";
	
		foreach (championsInfo champion in jsonList) {
			string json = JsonUtility.ToJson (champion);
			jsonToSave += json;
			Debug.Log ("adding to jsontosave: " + jsonToSave);
		}
			
		Debug.Log ("testing saving hash list as a json");

		Debug.Log ("json is: " + jsonToSave);
		File.WriteAllText (filePath, jsonToSave);
		/*BinaryFormatter bf = new BinaryFormatter();
		//Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
		FileStream file = File.Create (Application.persistentDataPath + "/savedGame.gd"); //you can call it anything you want
		bf.Serialize(file,data.championList);
		bf.Serialize (file, data.championNamesList);
		file.Close();*/
	}   

	public static void Load() {
		if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			//SaveLoad.savedGames = (List<Game>)bf.Deserialize(file);
			file.Close();
		}
	}

}
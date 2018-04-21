using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class championsInfo {

	public string championName = "test";
	public int top = 0;
	public int mid = 0;
	public int jungle = 0;
	public int adc = 0;
	public int support = 0;


	public string jsonString;
	public JsonData itemData;

	public void readJSON()
	{
		jsonString = File.ReadAllText(Application.dataPath + "/json/Champions.json");

		itemData = JsonMapper.ToObject (jsonString);

		Debug.Log (itemData["champions"]);
	
	}

}

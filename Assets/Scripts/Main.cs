using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using System.IO;

public class Main : MonoBehaviour {

	championsInfo championStatsInfo = new championsInfo();
	championNames champions = new championNames();


	// Use this for initialization
	void Start () {

		champions.setUpChampionNames ();

		foreach (string championName in data.championNamesList) {
			Debug.Log ("setting up all names: " + championName);
			Debug.Log ("adding champion hashtable data");
			championsInfo championData = new championsInfo ();
			championData.updateChampionInfo (data.championInfoEnum.NAME, championName);
			championData.updateChampionInfo (data.championInfoEnum.TOP, "1");
			championData.updateChampionInfo (data.championInfoEnum.MID, "1");
			championData.updateChampionInfo (data.championInfoEnum.JUNGLE, "1");
			championData.updateChampionInfo (data.championInfoEnum.ADC, "1");
			championData.updateChampionInfo (data.championInfoEnum.SUPPORT, "1");
			data.championList.Add (championData);

		}

		DataLoader.Save (data.championList);

		foreach (championsInfo championData in data.championList) {
			Debug.Log ("making sure champion data was saved: "+data.championInfoEnum.NAME.ToString());
			Debug.Log (championData.getChampionInfo(data.championInfoEnum.NAME));
	
		}
	
		championStatsInfo.updateChampionInfo (data.championInfoEnum.ADC, "2");
		Debug.Log("this is adc test:" + championStatsInfo.getChampionInfo(data.championInfoEnum.ADC));
		Debug.Log("this is other test: " + championStatsInfo.getChampionInfo(data.championInfoEnum.NAME));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

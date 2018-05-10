using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	championsInfo championStatsInfo = new championsInfo();

	// Use this for initialization
	void Start () {
		championStatsInfo.updateChampionInfo (championsInfo.championInfoEnum.ADC, "2");
		Debug.Log("this is adc test:" + championStatsInfo.getChampionInfo(championsInfo.championInfoEnum.ADC));
		Debug.Log("this is other test: " + championStatsInfo.getChampionInfo(championsInfo.championInfoEnum.NAME));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

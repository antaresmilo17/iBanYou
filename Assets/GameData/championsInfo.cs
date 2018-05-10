using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[SerializeField]
public class championsInfo {

	public string championName = "";
	public int top = 0;
	public int mid = 0;
	public int jungle = 0;
	public int adc = 0;
	public int support = 0;


	public void updateChampionInfo(data.championInfoEnum championInfo, string value)
	{
		switch (championInfo) 
		{
			case data.championInfoEnum.NAME:
				this.championName = value ;
				break;
			case data.championInfoEnum.ADC:
				this.adc = int.Parse(value);
				break;
			case data.championInfoEnum.JUNGLE:
				this.jungle = int.Parse(value) ;
				break;
			case data.championInfoEnum.MID:
				this.mid = int.Parse(value);
				break;
			case data.championInfoEnum.SUPPORT:
				this.support = int.Parse(value);
				break;
			case data.championInfoEnum.TOP:
				this.top = int.Parse(value);
				break;
		}
			
	}

	public string getChampionInfo(data.championInfoEnum championInfo)
	{
		string valueToReturn = "";

		switch (championInfo) 
		{
			case data.championInfoEnum.NAME:
				valueToReturn = this.championName;
				break;
			case data.championInfoEnum.ADC:
				valueToReturn = this.adc.ToString();
				break;
			case data.championInfoEnum.JUNGLE:
				valueToReturn = this.jungle.ToString();
				break;
			case data.championInfoEnum.MID:
				valueToReturn = this.mid.ToString();
				break;
			case data.championInfoEnum.SUPPORT:
				valueToReturn = this.support.ToString ();
				break;
			case data.championInfoEnum.TOP:
				valueToReturn = this.top.ToString ();
				break;
		}

		return valueToReturn;

	}

}

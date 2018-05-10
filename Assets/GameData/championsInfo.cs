using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class championsInfo {

	public enum championInfoEnum{
		NAME,
		TOP,
		MID,
		JUNGLE,
		ADC,
		SUPPORT
	};

	public Hashtable championInformation = new Hashtable();
	championInfoEnum championInfo;

	private string championName = "";
	private int top = 0;
	private int mid = 0;
	private int jungle = 0;
	private int adc = 0;
	private int support = 0;

	public void updateChampionInfoField(championInfoEnum championInfo, string value)
	{
		updateChampionInfo (championInfo, value);

	}

	public void updateChampionInfo(championInfoEnum championInfo, string value)
	{
		switch (championInfo) 
		{
			case championInfoEnum.NAME:
				this.championName = value ;
				break;
			case championInfoEnum.ADC:
				this.adc = int.Parse(value);
				break;
			case championInfoEnum.JUNGLE:
				this.jungle = int.Parse(value) ;
				break;
			case championInfoEnum.MID:
				this.mid = int.Parse(value);
				break;
			case championInfoEnum.SUPPORT:
				this.support = int.Parse(value);
				break;
			case championInfoEnum.TOP:
				this.top = int.Parse(value);
				break;
		}
			
	}

	public string getChampionInfo(championInfoEnum championInfo)
	{
		string valueToReturn = "";

		switch (championInfo) 
		{
			case championInfoEnum.NAME:
				valueToReturn = this.championName;
				break;
			case championInfoEnum.ADC:
				valueToReturn = this.adc.ToString();
				break;
			case championInfoEnum.JUNGLE:
				valueToReturn = this.jungle.ToString();
				break;
			case championInfoEnum.MID:
				valueToReturn = this.mid.ToString();
				break;
			case championInfoEnum.SUPPORT:
				valueToReturn = this.support.ToString ();
				break;
			case championInfoEnum.TOP:
				valueToReturn = this.top.ToString ();
				break;
		}

		return valueToReturn;

	}


	public void setUpChampionInformation()
	{
		championInformation.Add ("Name", championName);
		championInformation.Add ("Top", championName);
		championInformation.Add ("Mid", championName);
		championInformation.Add ("Jungle", championName);
		championInformation.Add ("Adc", championName);
		championInformation.Add ("Support", championName);
	
	}

}

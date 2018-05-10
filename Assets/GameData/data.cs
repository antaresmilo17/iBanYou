using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class data
{
	public enum championInfoEnum{
		NAME,
		TOP,
		MID,
		JUNGLE,
		ADC,
		SUPPORT
	};

	public static List<string> championNamesList = new List<string>();
	public static List<championsInfo> championList = new List<championsInfo>();

}

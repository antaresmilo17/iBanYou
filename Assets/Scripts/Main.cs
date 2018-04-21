using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public championsInfo test = new championsInfo();
	public Logger logger;
	// Use this for initialization
	void Start () {
		test.readJSON();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

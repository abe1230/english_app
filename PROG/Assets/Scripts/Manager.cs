﻿using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int i = Utility.GetRandomInt (4);
		Debug.Log (i);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

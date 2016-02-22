using UnityEngine;
using System.Collections;

public class Undestroyable : MonoBehaviour {


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Utility : MonoBehaviour {

	public static int GetRandomInt(int max = 0)
	{
		System.Random random = new System.Random ();
		if (max > 0)
			return random.Next (max + 1);
		else
			return random.Next ();
	}
	

}

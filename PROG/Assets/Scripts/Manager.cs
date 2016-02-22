using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Manager{

	private static Manager mInstance = null;


	public static Manager getManager()
	{
		if (mInstance == null)
		{
			mInstance = new Manager();
		}

		return mInstance;
	}

	public enum eScene
	{
		SCENE_TITLE = 0,
		SCENE_MENU,
		SCENE_PRACTICE,
	}

	string[] sceneNames = { "title", "main", "practice" };

	public void sceneTransition(eScene scene)
	{
		SceneManager.LoadScene(sceneNames[(int)scene]);

	}

	void Parse()
	{
		/*
		TextAsset textAsset = Resources.Load ("sample") as TextAsset;
		string jsonText = textAsset.text;
		Debug.Log (jsonText);
		Dictionary<string,object> json = Json.Deserialize (jsonText) as Dictionary<string,object>;
		Debug.Log ((string)json["word"] );
		*/
	}


}

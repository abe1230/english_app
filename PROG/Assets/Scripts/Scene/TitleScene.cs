using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TitleScene : MonoBehaviour {

	[UnityEngine.SerializeField]
	GameObject titlePanel;

	// Use this for initialization
	void Start () {

		titlePanel.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButton (GameObject obj)
	{
		Debug.Log(obj.name);

		if(obj.name == "push_start_button")
		{
			Debug.Log("pushStart");
			Manager.getManager().sceneTransition(Manager.eScene.SCENE_PRACTICE);
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PracticeScene : MonoBehaviour {

	int currentIndex = 0;

	public void Start()
	{
		Init ();
	}

	public void Init () {
		setBookValue ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButton(Button button)
	{
		Debug.Log (button.name);
		if (button.name == "nextButton")
			currentIndex++;
		else if (button.name == "backButton")
			currentIndex--;

		setBookValue ();
	}

	void setBookValue()
	{
		DataManager.Book book = DataManager.Instance.getBookData ();
		if (currentIndex >= book.words.Length)
			currentIndex = book.words.Length - 1;
		else if (currentIndex < 0)
			currentIndex = 0;
		string str = book.words [currentIndex].englishWord;
		Text word = GameObject.Find ("Canvas/Panel/word").GetComponent<Text> ();
		word.text = str;
		Text meaning = GameObject.Find ("Canvas/Panel/meaning").GetComponent<Text> ();
		meaning.text = book.words [currentIndex].japaneseTranslation;
	}
}

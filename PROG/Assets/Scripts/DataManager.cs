using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class DataManager : MonoBehaviour {

	/// <summary>
	/// 単語帳データ
	/// </summary>
	public class Book
	{
		public Word[] words;
		public class Word{
			public int index;
			public int category;
			public string word;
			public string japanese;
		}
	}

	public enum eCategory
	{
		/// <summary>
		/// 名詞.
		/// </summary>
		NOUN		= 0,
		/// <summary>
		/// 動詞.
		/// </summary>
		VERB 		= 1,
		/// <summary>
		/// 形容詞.
		/// </summary>
		ADJECTIVE 	= 2,

	}

	private static DataManager mInstance;
	Book bookData;
	public Book getBookData() {
		return bookData;
	}

	public static DataManager Instance {
		get {
			if (mInstance == null) {
				mInstance = new DataManager ();
				mInstance.Init ();
			}
			return mInstance;
		}

	}

	void Init ()
	{
		ParseJson ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void ParseJson()
	{
		TextAsset textAsset = Resources.Load ("sample") as TextAsset;
		bookData = LitJson.JsonMapper.ToObject<Book> (textAsset.text);

		Debug.Log (bookData.words [0].index);
		Debug.Log (bookData.words [0].category);
		Debug.Log (bookData.words [0].word);
		Debug.Log (bookData.words [0].japanese);
	}
}

using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class DataManager  {

	/// <summary>
	/// 単語帳データ
	/// </summary>
	[Serializable]
	public class Book
	{
		public Word[] words;

		[Serializable]
		public class Word{
			/// <summary>
			/// The index.
			/// </summary>
			public int index;
			/// <summary>
			/// カテゴリ
			/// </summary>
			public int category;
			/// <summary>
			/// 英単語.
			/// </summary>
			public string englishWord;
			/// <summary>
			/// 日本語訳.
			/// </summary>
			public string japaneseTranslation;
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
		var data = JsonUtility.FromJson<Book> (textAsset.text);
		bookData = data as Book;

		/*
		Debug.Log (bookData.words [0].index);
		Debug.Log (bookData.words [0].category);
		Debug.Log (bookData.words [0].englishWord);
		Debug.Log (bookData.words [0].japaneseTranslation);
		*/
	}
}

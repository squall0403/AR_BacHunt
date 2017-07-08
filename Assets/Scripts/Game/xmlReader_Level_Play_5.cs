using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine.UI;

public class xmlReader_Level_Play_5 : MonoBehaviour {
	public TextAsset dictionary;
	public string languageName;
	public static int currentLanguage;
	public Text level_play_text,btn_Replay;

	string txt_Level_Play,btn_Replay_text;

	List<Dictionary<string,string>>language = new List<Dictionary<string,string>>();
	Dictionary<string,string>obj;

	void Awake()
	{
		Reader ();
	}



	void Update(){
		language [currentLanguage].TryGetValue ("Name", out languageName);
		language [currentLanguage].TryGetValue ("play_level5", out txt_Level_Play);
		language [currentLanguage].TryGetValue ("btn_Try_again", out btn_Replay_text);
	}

	void OnGUI(){
		level_play_text.text=txt_Level_Play;
		btn_Replay.text = btn_Replay_text;
	}
	void Reader(){
		XmlDocument xmlDoc = new XmlDocument ();
		xmlDoc.LoadXml (dictionary.text);

		XmlNodeList languageList = xmlDoc.GetElementsByTagName ("language");

		foreach(XmlNode languageValue in languageList){
			XmlNodeList languageContent = languageValue.ChildNodes;
			obj = new Dictionary<string,string>();

			foreach(XmlNode value in languageContent){
				if(value.Name == "Name")
					obj.Add (value.Name, value.InnerText);
				if(value.Name == "play_level5" || value.Name == "btn_Try_again")
					obj.Add (value.Name, value.InnerText);
		
			}

			language.Add (obj);
		}
	}
}

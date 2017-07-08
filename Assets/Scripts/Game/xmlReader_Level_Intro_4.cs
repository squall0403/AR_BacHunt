using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine.UI;

public class xmlReader_Level_Intro_4 : MonoBehaviour {
	public TextAsset dictionary;
	public string languageName;
	public static int currentLanguage;
	public Text level_intro_Text,fact_Text,guide_Text,btn_Play_text;

	string txt_Level_Intro,txt_fact,txt_guide,btn_Play;

	List<Dictionary<string,string>>language = new List<Dictionary<string,string>>();
	Dictionary<string,string>obj;

	void Awake()
	{
		Reader ();
	}



	void Update(){
		language [currentLanguage].TryGetValue ("Name", out languageName);
		language [currentLanguage].TryGetValue ("btn_Play", out btn_Play);
		language [currentLanguage].TryGetValue ("level_intro", out txt_Level_Intro);
		language [currentLanguage].TryGetValue ("intro_level4", out txt_fact);
		language [currentLanguage].TryGetValue ("guide_Lv4", out txt_guide);
	}

	void OnGUI(){
		btn_Play_text.text=btn_Play;
		level_intro_Text.text=txt_Level_Intro;
		fact_Text.text=txt_fact;
		guide_Text.text=txt_guide;
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
				if(value.Name == "level_intro" || value.Name == "intro_level4" || value.Name == "guide_Lv4" || value.Name == "btn_Play")
					obj.Add (value.Name, value.InnerText);
		
			}

			language.Add (obj);
		}
	}
}

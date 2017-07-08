using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine.UI;

public class xmlReader_menu : MonoBehaviour {
	public TextAsset dictionary;
	public string languageName;
	public static int currentLanguage;
	public Text btn_Play_text;
	public Text btn_Exit_text;
	public Text btn_HTP_text;
	public Text btn_Dictionary_text;

	string btn_Play;
	string btn_Exit;
	string btn_HTP;
	string btn_Dictionary;

	List<Dictionary<string,string>>language = new List<Dictionary<string,string>>();
	Dictionary<string,string>obj;

	void Awake()
	{
		Reader ();
	}



	void Update(){
		language [currentLanguage].TryGetValue ("Name", out languageName);
		language [currentLanguage].TryGetValue ("btn_Play", out btn_Play);
		language [currentLanguage].TryGetValue ("btn_Exit", out btn_Exit);
		language [currentLanguage].TryGetValue ("btn_How_to_play", out btn_HTP);
		language [currentLanguage].TryGetValue ("btn_Bacteria_Dictionary", out btn_Dictionary);
	}

	void OnGUI(){
		btn_Play_text.text=btn_Play;
		btn_Exit_text.text=btn_Exit;
		btn_HTP_text.text=btn_HTP;
		btn_Dictionary_text.text=btn_Dictionary;
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

				if (value.Name == "btn_Play")
					obj.Add (value.Name, value.InnerText);

				if (value.Name == "btn_Exit")
					obj.Add (value.Name, value.InnerText);
				
				if (value.Name == "btn_How_to_play")
					obj.Add (value.Name, value.InnerText);
				
				if (value.Name == "btn_Bacteria_Dictionary")
					obj.Add (value.Name, value.InnerText);			
			}

			language.Add (obj);
		}
	}
}

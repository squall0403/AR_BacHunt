using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine.UI;

public class xmlReader_HTP : MonoBehaviour {
	public TextAsset dictionary;
	public string languageName;
	public static int currentLanguage;
	public Text HTP_1,HTP_2,HTP_3;

	string txt_HTP_1,txt_HTP_2,txt_HTP_3;

	List<Dictionary<string,string>>language = new List<Dictionary<string,string>>();
	Dictionary<string,string>obj;

	void Awake()
	{
		Reader ();
	}



	void Update(){
		language [currentLanguage].TryGetValue ("Name", out languageName);
		language [currentLanguage].TryGetValue ("how_to_play1", out txt_HTP_1);
		language [currentLanguage].TryGetValue ("how_to_play2", out txt_HTP_2);
		language [currentLanguage].TryGetValue ("how_to_play3", out txt_HTP_3);
	}

	void OnGUI(){
		HTP_1.text = txt_HTP_1;
		HTP_2.text = txt_HTP_2;
		HTP_3.text = txt_HTP_3;
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
				if(value.Name == "how_to_play1")
					obj.Add (value.Name, value.InnerText);
				if(value.Name == "how_to_play2")
					obj.Add (value.Name, value.InnerText);
				if(value.Name == "how_to_play3")
					obj.Add (value.Name, value.InnerText);
			}

			language.Add (obj);
		}
	}
}

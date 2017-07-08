using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine.UI;

public class xmlReader_Dict : MonoBehaviour {
	public TextAsset dictionary;
	public string languageName;
	public static int currentLanguage;
	public Text info_bacteriodies,info_ecoli,info_hepa,info_pseu,info_shigella,info_staph,info_kleb,info_strep;

	string txt_bacteriodies,txt_ecoli,txt_hepa,txt_pseu,txt_shigella,txt_staph,txt_kleb,txt_strep;

	List<Dictionary<string,string>>language = new List<Dictionary<string,string>>();
	Dictionary<string,string>obj;

	void Awake()
	{
		Reader ();
	}



	void Update(){
		language [currentLanguage].TryGetValue ("Name", out languageName);
		language [currentLanguage].TryGetValue ("bacteroides", out txt_bacteriodies);
		language [currentLanguage].TryGetValue ("ecoli", out txt_ecoli);
		language [currentLanguage].TryGetValue ("hepatitisa", out txt_hepa);
		language [currentLanguage].TryGetValue ("pseudomonas", out txt_pseu);
		language [currentLanguage].TryGetValue ("shigella", out txt_shigella);
		language [currentLanguage].TryGetValue ("staph", out txt_staph);
		language [currentLanguage].TryGetValue ("kleb", out txt_kleb);
		language [currentLanguage].TryGetValue ("strepto", out txt_strep);
	}

	void OnGUI(){
		info_bacteriodies.text = txt_bacteriodies;
		info_ecoli.text = txt_ecoli;
		info_hepa.text = txt_hepa;
		info_pseu.text = txt_pseu;
		info_shigella.text = txt_shigella;
		info_staph.text = txt_staph;
		info_kleb.text = txt_kleb;
		info_strep.text = txt_strep;
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
				if (value.Name == "bacteroides")
					obj.Add (value.Name, value.InnerText);
				
				if (value.Name == "ecoli")
					obj.Add (value.Name, value.InnerText);
				
				if(value.Name == "hepatitisa")
					obj.Add (value.Name, value.InnerText);
				
				if(value.Name == "pseudomonas")
					obj.Add (value.Name, value.InnerText);
				
				if(value.Name == "shigella")
					obj.Add (value.Name, value.InnerText);
				
				if(value.Name == "staph")
					obj.Add (value.Name, value.InnerText);
				
				if(value.Name == "kleb")
					obj.Add (value.Name, value.InnerText);
				
				if(value.Name == "strepto")
					obj.Add (value.Name, value.InnerText);
			}

			language.Add (obj);
		}
	}
}


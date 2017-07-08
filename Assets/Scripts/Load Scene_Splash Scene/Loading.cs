using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

public float loadingTime;
public Image loadingBar;
public Text percent;
	// Use this for initialization
	void Start () {

		loadingBar.fillAmount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(loadingBar.fillAmount <= 1) 
		{
		loadingBar.fillAmount += 1.0f / loadingTime * Time.deltaTime;
	}

		percent.text = (loadingBar.fillAmount * 100).ToString ("f0");

		if(loadingBar.fillAmount == 1.0f)
		{
			SceneManager.LoadScene("Language_select");
		}
	}
}


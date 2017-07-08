using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class ClicktheWrong : MonoBehaviour {
	public static int score;
	public Text scoreText;
	
	void OnMouseDown()
	{
		Destroy (this.gameObject);
		score = score-1;
	}

	void Update () {
	scoreText.text = "Điểm: " + score;
	}

}

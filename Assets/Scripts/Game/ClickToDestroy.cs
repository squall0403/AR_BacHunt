using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class ClickToDestroy : MonoBehaviour {
	public static int score;
	public Text scoreText;



	void OnMouseDown() {
		Scene activeScene = SceneManager.GetActiveScene ();
		if (activeScene.name=="Level 1_Play"){
			if(this.gameObject.name == "SHI" || this.gameObject.name == "STRE" || this.gameObject.name == "MIL MINT"){
				Destroy (this.gameObject);
				score++;}
			else {
				if (score > 0) {
					score--;
				}
			} 
		}

		if (activeScene.name=="Level 2_Play"){
			if(this.gameObject.name == "SHI" || this.gameObject.name == "HEP"){
				Destroy (this.gameObject);
				TimerCountdownL2Win.level_score++;
				score++;}
			else {
				if (score > 0) {
					score--;
				}
			} 
		}

		if (activeScene.name=="Level 3_Play"){
			if(this.gameObject.name == "ECO (1)" || this.gameObject.name == "ECO (2)" || this.gameObject.name == "ECO"){
				Destroy (this.gameObject);
				TimerCountdownL3Win.level_score++;
				score++;}
			else {
				if (score > 0) {
					score--;
				}
			} 
		}

		if (activeScene.name=="Level 4_Play"){
			Destroy (this.gameObject);
			TimerCountdownL4Win.level_score++;
			score++;
		}
			
	}
	void Update () {
		Scene activeScene = SceneManager.GetActiveScene ();
		if (activeScene.name != "Level 5_Play") {
			scoreText.text = "Điểm: " + score;
		}
	}

}
//
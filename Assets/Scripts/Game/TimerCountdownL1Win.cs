using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerCountdownL1Win : MonoBehaviour {
	public int timeLeft=10, target_score;
	public static int intial_score; //Intial score will remember the score user earned from previous scene
    public Text countdownText;
	public Button btn_replay;

	void clearObjects(){
		var gameObjects = GameObject.FindGameObjectsWithTag ("Bacteria");

		for (var i = 0; i < gameObjects.Length; i++) {
			Destroy (gameObjects [i]);
		}
	}

    void Start ()
    {
        StartCoroutine("LoseTime");
		intial_score = ClickToDestroy.score;
    }




 void Update()
 {
		if (timeLeft < 10) {
			countdownText.text = ("00:0" + timeLeft);
		} else {
			countdownText.text = ("00:" + timeLeft);
		}
		if (timeLeft < 0) {
			StopCoroutine ("LoseTime");
		}

		if (timeLeft ==0 && ClickToDestroy.score < target_score)
     {
         StopCoroutine("LoseTime");
			if (MenuActions.langSelected == "VN") {
				countdownText.text = "Hết giờ!";
			} else {
				countdownText.text = "Time up!";
			}

			ClickToDestroy.score = intial_score; //Assign user score to intial score

			clearObjects ();

			StartCoroutine("DelayScene");

     }
	
		if (ClickToDestroy.score == target_score) {

			clearObjects ();

			StartCoroutine("WinWait");

		}

 }
 IEnumerator LoseTime()
 {
     while (true)
     {
         yield return new WaitForSeconds(1);
         timeLeft--;
     }
 }

	IEnumerator DelayScene()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			btn_replay.gameObject.SetActive (true);
		}
	}

	IEnumerator WinWait()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			SceneManager.LoadScene("Level 2_Intro");
		}
	}
}

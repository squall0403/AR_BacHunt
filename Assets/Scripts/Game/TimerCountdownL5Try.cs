using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountdownL5Try : MonoBehaviour {
    public int timeLeft = 5;
    public Text countdownText;
	public Button btn_replay;
	public static bool isEnabled = true;

	public AudioClip otherClip;
	public AudioSource _audio;

    void Start ()
    {
		_audio.Play ();
        StartCoroutine("LoseTime");
    }
		 	
	void Update()
	{
		if (isEnabled == false) {
			this.enabled = false;
			_audio.clip = otherClip;
			_audio.Stop ();
		}
		if (timeLeft < 10) {
			countdownText.text = ("00:0" + timeLeft);
		} else {
			countdownText.text = ("00:" + timeLeft);
		}


		if (timeLeft == 0) {
			StopCoroutine ("LoseTime");
			if (MenuActions.langSelected == "VN") {
				countdownText.text = "Hết giờ!";
			} else {
				countdownText.text = "Time up!";
			}
		
			StartCoroutine ("DelayScene");
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
			//SceneManager.LoadScene("Level 5_Intro");
		}
	}
}
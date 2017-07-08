using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DestroyAll : MonoBehaviour {
	public Image habi_message;

	// Use this for initialization
	void OnMouseDown()
	{
		 var gameObjects = GameObject.FindGameObjectsWithTag ("Bacteria");
     
		 for(var i = 0 ; i < gameObjects.Length ; i ++)
		 {
			 Destroy(gameObjects[i]);
		 }
		TimerCountdownL5Try.isEnabled = false;
		StartCoroutine("DelayScene");		
	}
	IEnumerator DelayScene()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			habi_message.gameObject.SetActive (true);
		}
	}
}

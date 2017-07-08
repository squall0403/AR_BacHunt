using UnityEngine;
using System.Collections;

public class DestroySound : MonoBehaviour {
	public AudioClip clip;

	// Use this for initialization
	void OnMouseDown() {
		AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
	}
}

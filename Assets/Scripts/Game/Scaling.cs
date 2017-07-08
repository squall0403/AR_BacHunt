using UnityEngine;
using System.Collections;

public class Scaling : MonoBehaviour { 
	public int startSize = 3;
	public int minSize = 1;
	public int maxSize = 20;

	public float speed = 5.0f;

	private Vector3 targetScale;
	private Vector3 baseScale;
	private int currScale;

	void Start() {
		baseScale = transform.localScale;
		transform.localScale = baseScale * startSize;
		currScale = startSize;
		targetScale = baseScale * startSize;
	}

	void Update ()
	{
		transform.localScale = Vector3.Lerp (transform.localScale, targetScale, speed * Time.deltaTime);
	}
}
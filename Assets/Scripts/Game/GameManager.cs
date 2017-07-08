using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager> {

private int _numBacs;

public int NumBacs {
	get {return _numBacs; }
	set { _numBacs = value; }
}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

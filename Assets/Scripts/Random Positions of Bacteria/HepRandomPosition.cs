﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HepRandomPosition : MonoBehaviour {
    public Vector3[] positions; 
    // Use this for initialization
    void Start () {
        int randomNumber = Random.Range(0,positions.Length);
        transform.position=positions[randomNumber];
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}

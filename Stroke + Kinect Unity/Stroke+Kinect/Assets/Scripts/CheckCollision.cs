﻿using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {

    public int targetID = 0;
    public GameObject drawingManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TargetCollision()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
        drawingManager.GetComponent<DrawingManager>().AssignNextTarget(targetID);
       // Debug.Log("collision");
    }
}

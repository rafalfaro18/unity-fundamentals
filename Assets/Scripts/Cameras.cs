﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour {


	public Transform player = null;
	public Transform target = null; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate () {
		//this.transform.LookAt (player.position);
		this.transform.position = target.position;

	}
}

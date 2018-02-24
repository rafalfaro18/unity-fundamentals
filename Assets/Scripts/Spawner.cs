﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject spawnType = null;
	public float scaleMin = 0.2f;
	public float scaleMax = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject obj = Instantiate (spawnType) as GameObject;
			obj.transform.position = this.transform.position;
			obj.AddComponent<Rigidbody> ();
			float scaleSize = Random.Range (scaleMin, scaleMax);
			obj.transform.localScale = Vector3.one * scaleSize;
			obj.name = "mySphere";
		}
	}
}

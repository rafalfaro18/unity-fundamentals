using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExamples : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Debug.Log ("Object: " + other.name + " entered trigger.");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

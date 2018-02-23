using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

	public GameObject lightBulb = null;

	void OnTriggerEnter (Collider other){
		if (other.name == "player") {
			lightBulb.SetActive (true);
		}
	}

	void OnTriggerExit (Collider other){
		if (other.name == "player") {
			lightBulb.SetActive (false);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

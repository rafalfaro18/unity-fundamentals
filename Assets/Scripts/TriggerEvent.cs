using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

	public GameObject lightBulb = null;
	public GameObject wall = null;

	void OnTriggerEnter (Collider other){
		if (other.name == "player") {
			lightBulb.SetActive (true);
			wall.GetComponent<ObjectScaling> ().EnableScale ();
		}
	}

	void OnTriggerExit (Collider other){
		if (other.name == "player") {
			lightBulb.SetActive (false);
			wall.GetComponent<ObjectScaling> ().DisableScale ();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

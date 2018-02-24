using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

	public GameObject lightBulb = null;
	public GameObject wall = null;
	public AudioClip lightBulbOn = null;

	void OnTriggerEnter (Collider other){
		if (other.name == "player") {
			lightBulb.SetActive (true);
			GetComponent<AudioSource>().PlayOneShot (lightBulbOn);
			wall.GetComponent<ObjectScaling> ().EnableScale ();
			wall.GetComponent<ObjectColor> ().EnableColor();
		}
	}

	void OnTriggerExit (Collider other){
		if (other.name == "player") {
			lightBulb.SetActive (false);
			GetComponent<AudioSource>().Stop ();
			wall.GetComponent<ObjectScaling> ().DisableScale ();
			wall.GetComponent<ObjectColor> ().DisableColor();

		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

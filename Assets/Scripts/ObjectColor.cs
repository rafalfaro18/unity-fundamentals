using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour {

	public Color changedColor = Color.white;
	public Color originalColor = Color.white;

	void Awake (){
		originalColor = this.GetComponent<Renderer>().material.color;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			this.GetComponent<Renderer>().material.color = changedColor;
		} else if (Input.GetKeyUp (KeyCode.G)) {
			this.GetComponent<Renderer>().material.color = originalColor;
		}
	}
}

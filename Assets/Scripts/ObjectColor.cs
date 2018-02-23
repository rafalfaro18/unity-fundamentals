using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour {

	public Color changedColor = Color.white;
	private Color originalColor = Color.white;

	void Awake (){
		originalColor = this.GetComponent<Renderer>().material.color;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			EnableColor ();
		} else if (Input.GetKeyUp (KeyCode.G)) {
			DisableColor ();
		}
	}

	public void EnableColor(){
		this.GetComponent<Renderer>().material.color = changedColor;
	}

	public void DisableColor(){
		this.GetComponent<Renderer>().material.color = originalColor;
	}
}

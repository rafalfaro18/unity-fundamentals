using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("UpArrow Pressed");
			this.transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("DownArrow Pressed");
			this.transform.Translate (new Vector3 (0, 0, -speed * Time.deltaTime));
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log ("LeftArrow Pressed");
			this.transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ("RightArrow Pressed");
			this.transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
		}
	}
}
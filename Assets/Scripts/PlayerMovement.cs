using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 5.0f;
	public float rotateSpeed = 100.0f;
	public bool canMoveSideways = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Movement ();
	}

	void Movement() {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("UpArrow Pressed");
			this.transform.Translate (new Vector3 (0, 0, moveSpeed * Time.deltaTime));
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("DownArrow Pressed");
			this.transform.Translate (new Vector3 (0, 0, -moveSpeed * Time.deltaTime));
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (canMoveSideways) {
				Debug.Log ("LeftArrow Pressed");
				this.transform.Translate (new Vector3 (-moveSpeed * Time.deltaTime, 0, 0));
			} else {
				Debug.Log ("LeftArrow Pressed: Rotate");
				this.transform.Rotate (new Vector3 (0, -rotateSpeed * Time.deltaTime, 0));
			}
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			if (canMoveSideways) {
				Debug.Log ("RightArrow Pressed");
				this.transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0, 0));
			} else {
				Debug.Log ("RightArrow Pressed: Rotate");
				this.transform.Rotate (new Vector3(0,rotateSpeed*Time.deltaTime,0));
			}
		}

		if (Input.GetKey (KeyCode.W)) {
			Debug.Log ("W Pressed");
			this.transform.Translate (new Vector3 (0, moveSpeed * Time.deltaTime, 0));
		} else if (Input.GetKey (KeyCode.S)) {
			Debug.Log ("S Pressed");
			this.transform.Translate (new Vector3 (0, -moveSpeed * Time.deltaTime, 0));
		}
	}
}
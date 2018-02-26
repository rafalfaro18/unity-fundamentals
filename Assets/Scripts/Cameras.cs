using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour {


	public Transform player = null;
	public Transform target = null; 
	public Vector3 speed = new Vector3(4.0f, 2.0f, 1.0f);
	public Vector3 nextPosition = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate () {

		nextPosition.x = Mathf.Lerp (this.transform.position.x , target.position.x, speed.x * Time.deltaTime);
		nextPosition.y = Mathf.Lerp (this.transform.position.y , target.position.y, speed.y * Time.deltaTime);
		nextPosition.z = Mathf.Lerp (this.transform.position.z , target.position.z, speed.z * Time.deltaTime);
		this.transform.position = nextPosition;
		//this.transform.position = target.position;
		this.transform.LookAt (player.position);

	}
}

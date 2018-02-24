using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject spawnType = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject obj = Instantiate (spawnType) as GameObject;
			obj.transform.position = this.transform.position;
			obj.AddComponent<Rigidbody> ();
		}
	}
}

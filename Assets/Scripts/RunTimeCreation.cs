using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTimeCreation : MonoBehaviour {

	public PrimitiveType primitiveType = PrimitiveType.Cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			CreatePrimitiveCube ();
		}
	}

	void CreatePrimitiveCube(){
		GameObject obj = GameObject.CreatePrimitive (primitiveType);
		obj.AddComponent<Rigidbody> ();
	}
}

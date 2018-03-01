using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour {

	private Animator animator;

	void Awake(){
		animator = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			animator.Play ("cubeMove");
		}
	}
}

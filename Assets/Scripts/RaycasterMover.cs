using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasterMover : MonoBehaviour {


	public Camera camera;
	private Ray ray;
	private RaycastHit hit;
	private GameObject hitObject = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Get Object
		if(Input.GetMouseButtonDown(0)){
			ray = camera.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray, out hit)){
				if(hit.collider.name == "Cube"){
					hitObject = hit.collider.gameObject;
				}
			}
		}

		if(hitObject){
			//Hold Object
			if(Input.GetMouseButton(0)){
				ray = camera.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out hit)) {
					hitObject.transform.position = new Vector3 (hit.point.x, hitObject.transform.position.y , hit.point.z);
				}
			}
			//Drop Object
		}
	}
}

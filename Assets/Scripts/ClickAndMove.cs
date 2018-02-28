using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndMove : MonoBehaviour {

	public Camera camera;
	public Transform player;
	public Vector3 moveToPosition;
	public float speed = 5;
	private Ray ray;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			ray = camera.ScreenPointToRay (Input.mousePosition);

			if(Physics.Raycast(ray, out hit)){
				if(hit.collider.name == "Plane"){
					moveToPosition = hit.point;

				}
			}
		}

		player.transform.position = Vector3.Lerp (player.transform.position, moveToPosition, speed * Time.deltaTime);
	}
}

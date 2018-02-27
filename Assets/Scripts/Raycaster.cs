using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour {

	public Camera camera;
	public GameObject obj;
	private Ray ray;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			ray = camera.ScreenPointToRay (Input.mousePosition);
//			if(Physics.Raycast(ray, out hit )){
//				if(hit.collider){
//					Debug.Log ("Hit " + hit.collider.name);
//					Instantiate(obj, hit.point, hit.transform.rotation);
//				}
//			}
			RaycastHit[] hits = null;
			hits = Physics.RaycastAll (ray);
			if(hits.Length > 0){
				for(int i=0; i<hits.Length; i++){
					Debug.Log ("Hit " + hits[i].collider.name);
				}
			}
		}
		Debug.DrawLine (ray.origin, hit.point, Color.red);
	}
}

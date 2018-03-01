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
		if (Input.GetKeyDown (KeyCode.S)) {
			CreateTriangle ();
		}
	}

	void CreatePrimitiveCube(){
		GameObject obj = GameObject.CreatePrimitive (primitiveType);
		obj.AddComponent<Rigidbody> ();   
	}

	void CreateTriangle(){
		GameObject obj = new GameObject ();
		obj.name = "Runtime created gameObject";

		MeshFilter meshFilter = obj.AddComponent<MeshFilter> ();
		Mesh mesh = meshFilter.mesh;

		mesh.Clear ();
		mesh.vertices = new Vector3[]{ new Vector3(0,0,0), new Vector3(0,1,0), new Vector3(1,1,0)};
		mesh.uv = new Vector2[]{new Vector2(0,0), new Vector2(0,1), new Vector2(1,1)};
		mesh.triangles = new int[] { 0,1,2};
		mesh.RecalculateNormals ();
		mesh.RecalculateBounds ();

		MeshRenderer meshRenderer = obj.AddComponent<MeshRenderer> ();
		Material material = new Material (Shader.Find("Diffuse"));
		material.color = Color.blue;
		meshRenderer.material = material;

		MeshCollider meshCollider = obj.AddComponent<MeshCollider> ();
		obj.layer = 0;
		obj.tag = "Player";
	}
}

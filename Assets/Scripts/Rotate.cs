using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.RotateAround(transform.position, new Vector3(1,0,0), 0.01f);
	}
}

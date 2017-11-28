using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baja : MonoBehaviour {
	float y;
	// Use this for initialization
	void Start () {
		y = transform.position.y;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.O)) {

			y -= 3f;
			transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		}
	}
}

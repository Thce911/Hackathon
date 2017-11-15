using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, 0.12f);
		
		}if (Input.GetKey(KeyCode.S)) {
			transform.Translate (0, 0, -0.12f);

		}if (Input.GetKey(KeyCode.A)) {
			transform.Translate (-0.12f, 0, 0);

		}if (Input.GetKey(KeyCode.D)) {
			transform.Translate (0.12f, 0, 0);

		}

		
		
	}
	void OnTriggerEnter(){

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class norte : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// Orient an object to point northward.
		transform.rotation = Quaternion.Euler(0, -Input.compass.trueHeading, 0);
	}
}

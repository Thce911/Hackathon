using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparaCorrected : MonoBehaviour {

	public Rigidbody projectil;
	public Transform puntodelanzamiento;
	float v = 50f;
	void Start () {
		v=50f;	
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.V)) {
			v += 10f;}
		if (Input.GetKeyDown (KeyCode.B)) {
			v -= 10f;}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, transform.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,v));
			
		}	

}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//; punto y coma esta junto a la Ñ
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)){
			transform.Translate(0,0,2f);
		}
		if (Input.GetKey (KeyCode.S)){
			transform.Translate(0,0,-2f);
		}
		if (Input.GetKey (KeyCode.A)){
			transform.Translate(2f,0,0);
		}
		if (Input.GetKey (KeyCode.D)){
			transform.Translate(-2f,0,0);
		}

	}

	//; punto y coma esta junto a la Ñ
	void OnTriggerEnter(Collider other)
	{
		MeshRenderer meshr;
		Light lighft;
		meshr=other.GetComponent<MeshRenderer> ();
		meshr.enabled = true;

	}


}

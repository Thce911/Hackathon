﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {
	bool arribaBool;
	bool abajoBool;

	bool izquierdaBool;
	bool derechaBool;
	// Use this for initialization
	void Start () {
		arribaBool = false;
		abajoBool = false;
		izquierdaBool = false;
		derechaBool = false;
		//; punto y coma esta junto a la Ñ
	}
	
	// Update is called once per frame
	void Update () {
		/* if (Input.GetKey (KeyCode.W)){
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



		if (arribaBool == true) {
			transform.Translate(0,0,2f);
		}
		if (abajoBool == true) {
			transform.Translate(0,0,-2f);
		}
		if (izquierdaBool == true) {
			transform.Translate(2f,0,0);
		}
		if (derechaBool == true) {
			transform.Translate (-2f, 0, 0);
		}*/

	}

	//; punto y coma esta junto a la Ñ
	void OnTriggerEnter(Collider other)
	{
		MeshRenderer meshr;
		Light lighft;
		meshr=other.GetComponent<MeshRenderer> ();
		meshr.enabled = false;

	}
	/*
	public void arribaOprime(){
		arribaBool = true;
	}
	public void arrbaSuelta(){
		arribaBool = false;
	
	}


	public void abajoOprime(){
		abajoBool = true;
	}
	public void abajoSuelta(){
		abajoBool = false;

	}

	public void izquierdaOprime(){
		izquierdaBool = true;
	}
	public void izquierdaSuelta(){
		izquierdaBool = false;

	}
	public void derechaOprime(){
		derechaBool = true;
	}
	public void derechaSuelta(){
		derechaBool = false;

	} */

}

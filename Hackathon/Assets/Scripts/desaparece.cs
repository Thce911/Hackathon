using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparece : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		Destroy (this.gameObject);



	}
}

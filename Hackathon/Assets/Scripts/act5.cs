using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class act5 : MonoBehaviour {
	public Image FalseImage;
	public Image TrueImage;
	public Transform grupo;
	public Transform gruposiguiente;
	bool mueve;
	//public Text t;
	int n;



	// Use this for initialization
	void Start () {
		mueve = false;
		n = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		n++;

		if (mueve == true) {
			
				grupo.Translate (4f, 0, 0);
				if (gruposiguiente.position.y< 300f) {
					gruposiguiente.Translate (0, 10f, 0);

				}
				//t.text = "gs:" + gruposiguiente.position.y;
			
		
		
		}


		
	}
	public void MCorrecto(){
		TrueImage.enabled = true;
		FalseImage.enabled = false;
		mueve = true;
		globalvariablesm.puntosglobales++;




	}
	public void MFalso(){
		TrueImage.enabled = false;
		FalseImage.enabled = true;
		mueve = true;



	}
}

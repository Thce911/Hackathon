using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class act3 : MonoBehaviour {

	public Button boton1;
	public Button boton2;
	public Button boton3;
	public Button boton4;

	public Text textotiempo;

	int a;
	int b;
	int c;
	int d;

	public Image true1;
	public Image true2;
	public Image false1;
	public Image false2;

	double tiempototal;
	int tiempoINT;

	// Use this for initialization
	void Start () {
		tiempototal = 10;

	}
	
	// Update is called once per frame
	void Update () {
		
		tiempototal = tiempototal - Time.deltaTime;
		tiempoINT = (int)tiempototal;
		textotiempo.text = "Tiempo:" + tiempoINT;

		if (tiempototal <= 0) {
			tiempototal = 0;
			boton1.enabled = false;
			boton2.enabled = false;
			boton3.enabled = false;
			boton4.enabled = false;

			boton1.image.enabled = false;
			boton2.image.enabled = false;
			boton3.image.enabled = false;
			boton4.image.enabled = false;
		}

		
	}
	public void Boton1m(){
		//trueimage.enabled = true;

		//boton1.colors=colorblockROJO;
		false1.enabled=true;

	}
	public void Boton2m(){
		true1.enabled = true;
		globalvariablesm.puntosglobales++;
		
	
		

	}
	public void Boton3m(){
		
		true2.enabled = true;
		globalvariablesm.puntosglobales++;


	}
	public void Boton4m(){
		false2.enabled = true;
	

	}

	public void TRYAGAINACT3(){
		boton1.image.enabled = true;
		boton2.image.enabled = true;
		boton3.image.enabled = true;
		boton4.image.enabled = true;
		boton1.enabled = true;
		boton2.enabled = true;
		boton3.enabled = true;
		boton4.enabled = true;
		false1.enabled = false;
		false2.enabled = false;
		true1.enabled = false;
		true2.enabled = false;
		tiempototal = 10;
		tiempoINT = 10;
	
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class act3 : MonoBehaviour {
	//en esta actividad hay una pregunta donde hay cuatro respuestas de las cuales solo dos son correctas
	//se hace la declaracion de los botones, las respuestas, la 1,2,3 y 4
	public Button boton1;
	public Button boton2;
	public Button boton3;
	public Button boton4;

	//necesito un label para imprimir el tiempo en cuenta regreciba en pantalla
	public Text textotiempo;

	int a;
	int b;
	int c;
	int d;

	//declaro las imagenes de correcto e incorrecto que apareceran dependiendo de la respuesta elegida
	public Image true1;
	public Image true2;
	public Image false1;
	public Image false2;
	//declaro la variable del tiempo
	double tiempototal;
	int tiempoINT;

	// Use this for initialization
	void Start () {
		//cuando empieza la actividad el reloj empieza en 10 segundos y se va a ir restando
		tiempototal = 10;

	}
	
	// Update is called once per frame
	void Update () {
		//en ela siguiente linea, el tiempo se ira restando, ira en cuenta regresiva hasta llegar a cero
		tiempototal = tiempototal - Time.deltaTime;
		//debido a que UNITY toma las variables del tiempo, su contador de segundos, como una variable decimal, hay que truncarle los decimales, convirtiendo el double a un int
		tiempoINT = (int)tiempototal;
		//imprimo el tiempo restante en la pantalla en un label
		textotiempo.text = "Tiempo:" + tiempoINT;

		if (tiempototal <= 0) {
			//si el tiempo llega a ser cero, los botones se deshabilidan, y las imagenes de los botones desaparecen
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

		//arroja incorrecto
		false1.enabled=true;

	}
	public void Boton2m(){

		//Arroja correcto
		true1.enabled = true;
		//Te suma puntos en tus puntos globales por ser respuesta correcta

		globalvariablesm.puntosglobales++;
		
	
		

	}
	public void Boton3m(){
		//Arroja correcto y te suma puntos globales por ser una respuesta correcta
		
		true2.enabled = true;
		globalvariablesm.puntosglobales++;


	}
	public void Boton4m(){

		//Arroja incorrecto
		false2.enabled = true;
	

	}

	public void TRYAGAINACT3(){

		//reinicia la actividad en caso de que tu lo desees
		//todos los botones los vuelve a habilitar y pone sus imagenes, y las imagenes de correcto y falso las desaparece
		//el tiempo lo regresa a 10
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

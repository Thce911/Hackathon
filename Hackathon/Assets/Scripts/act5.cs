using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class act5 : MonoBehaviour {
	public Image FalseImage;
	public Image TrueImage;

	//grupo y grupo siguiente son publicos de modo que le puedo aplicar este codigo a cada una de las preguntas para solo especificarle en la escena cual es el grupo actual y cual es el que sigue, cual va a traer despues
	public Transform grupo;
	public Transform gruposiguiente;
	bool mueve;
	//public Text t;
	int n;

	//en esta actividad van apareciendo las preguntas con sus respuestas opcionales en pantalla, en el momento en que tu eliges una, te arroja el resultado y la pregunta junto con la respuesta se mueve al lado derecho y se arrastra al principio la nueva pregunta


	// Use this for initialization
	void Start () {
		//el movimiento es un bool que empieza como falso, sera true cuando se arroje una respuesta
		mueve = false;
		n = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		n++;

		if (mueve == true) {

			//si la variable mueve se vuelve true, el grupo actual se movera a la derecha, y el siguiente hacia arriba hasta llegar a la posicion 300 en y, que es donde estaba la anterior
				grupo.Translate (4f, 0, 0);
				if (gruposiguiente.position.y< 300f) {
					gruposiguiente.Translate (0, 10f, 0);

				}
				//t.text = "gs:" + gruposiguiente.position.y;
			
		
		
		}


		
	}
	public void MCorrecto(){

		//si es correcta la respuesta, la imagen de correcto se mostrara, desaparece la imagen de falso por si esta activa, se activa el bool mueve y se suman puntos en la variable global
		TrueImage.enabled = true;
		FalseImage.enabled = false;
		mueve = true;
		globalvariablesm.puntosglobales++;




	}
	public void MFalso(){
		//si es incorrecta la respuesta, la imagen de true se deshabilita, la imagen de false se habilita, y se activa el bool mueve
		TrueImage.enabled = false;
		FalseImage.enabled = true;
		mueve = true;



	}
}

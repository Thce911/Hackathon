using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PREGUNTAABIERTA1 : MonoBehaviour {

	//declaro las imagenes de correcto e incorrecto
	public Image correctoimage;
	public Image falsoimage;
	//declaro como public el Inputfield/ el textbox donde se escribira la respuesta para analizarlo
	public InputField respuestaInput;



	// Use this for initialization
	//   ||
	//
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Okmetodo ()
	{
		//analizo la respuesta, la respuesta correcta es el nombre de la escuela UNAM, pero debido a que hay varias formas de escribirlo, debe haber un "if" que contenga todas las opciones correctas"
		if (respuestaInput.text == "UNAM" || respuestaInput.text == "unam" ||respuestaInput.text == "Universidad Autonoma de Mexico" || respuestaInput.text == "Universidad Autónoma de México" || respuestaInput.text == "universidad autonoma de mexico") {
			correctoimage.enabled = true; //se activa la imagen de correcto
			falsoimage.enabled = false; //Se desactiva la imagen de incorrecto (en caso de que estuviera activada)
			globalvariablesm.puntosglobales++;//Se suman puntos a la variable global
		
		} else {
			falsoimage.enabled = true; // si la respuesta no tiene nada que ver con lo esperado, la imagen de coorrecto desaparece por si estaba activa y la de incorrecto aparece
			correctoimage.enabled = false; 
		}
	

	}
}

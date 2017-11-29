using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Truefalse2 : MonoBehaviour {
	public InputField textbox;
	public Image trueimage;   //DECLARACION DE IMAGENES DE VERDADERO Y FALSO
	public Image falseimage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void VERDADERO(){
		//en caso de que sea verdadero, se activa este codigo, la imagen de la palomita aparece, y la del tache rojo en caso de estar presente desaparece
		trueimage.enabled=true;
		falseimage.enabled = false;

		//se suman puntos a la variable global
		globalvariablesm.puntosglobales++;
	
	}
	public void FALSO(){

		//en caso de que sea falso, se activa este codigo donde la imagen de incorrecto con la tacha aparece, y en caso de estar presente la imaen de la palomita, esta desaparece
		
		falseimage.enabled=true;
		trueimage.enabled = false;
	
	}
	public void CHECAR(){
		// se activa el metodo y se evalua el InputField/textbox, estamos buscando que la respuestas sea 4, si es asi, se llama al metodo VERDADERO(), SI NO se llama al metodo FALSO()
		if (textbox.text == "4") {
			VERDADERO ();
		} else {
			FALSO ();
		}
	
	
	
	}
	public void TRYAGAIN(){

		//en caso de que el usuario quiera intentarlo de nuevo, se llama a este metodo el cual deshabilita las imagenes de la palomita y la tacha, y el texbox/inputfield lo vacia
		trueimage.enabled = false;
		falseimage.enabled = false;
		textbox.text = "";
	}
}

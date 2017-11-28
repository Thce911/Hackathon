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
		//trueimage.enabled = true;
		trueimage.enabled=true;
		falseimage.enabled = false;
		globalvariablesm.puntosglobales++;
	
	}
	public void FALSO(){
		//falseimage.enabled = true;
		falseimage.enabled=true;
		trueimage.enabled = false;
	
	}
	public void CHECAR(){
		if (textbox.text == "4") {
			VERDADERO ();
		} else {
			FALSO ();
		}
	
	
	
	}
	public void TRYAGAIN(){
		trueimage.enabled = false;
		falseimage.enabled = false;
		textbox.text = "";
	}
}

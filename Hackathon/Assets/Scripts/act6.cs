using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class act6 : MonoBehaviour {
	public Text textoss;
	int cont;
	double tiempo;
	public Image trueimage;
	public Image falseimage;


	public Image EnriqueImage;
	public Image SalvadorImage;
	public Image SantiagoImage;
	public Image JeffImage;
	bool tiempotrue;
	// Use this for initialization
	void Start () {
		cont = 1;
		tiempo = 0;
		tiempotrue = false;
	}

	// Update is called once per frame
	void Update () {


		textoss.text =""+ tiempo;

		if (tiempo >= 1) {
			tiempo = 0;
			if (cont == 1) {
				EnriqueImage.enabled = false;
				trueimage.enabled = false;
				falseimage.enabled = false;
			}
			if (cont == 2) {
				SalvadorImage.enabled = false;
				trueimage.enabled = false;
				falseimage.enabled = false;
			}
			if (cont == 3) {
				SantiagoImage.enabled = false;
				trueimage.enabled = false;
				falseimage.enabled = false;
			}
			if (cont == 4) {
				JeffImage.enabled = false;
				trueimage.enabled = false;
				falseimage.enabled = false;
			}
		
			tiempotrue = false;
			cont++;
		}
		if (tiempotrue == true) {
			tiempo = tiempo + Time.deltaTime;
		
		}
		
	}
	public void Enrique(){
		if (cont == 1) {
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			falseimage.enabled = true;
			trueimage.enabled = false;}
		
		tiempotrue = true;
	}
	public void Salvador(){
		if (cont == 2) {
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			falseimage.enabled = true;
			trueimage.enabled = false;}
		

		tiempotrue = true;
	}
	public void Santiago(){

		if (cont == 3) {
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			falseimage.enabled = true;
			trueimage.enabled = false;}
		

		tiempotrue = true;
	}
	public void Jeff(){


		if (cont == 4) {
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			falseimage.enabled = true;
			trueimage.enabled = false;}
		

		tiempotrue = true;
	}

}

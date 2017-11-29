using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class act6 : MonoBehaviour {
	public Text textoss;
	int cont;
	double tiempo;
	//En este codigo es sobre acertar la imagen corresponde a la cara de que personaje
	public Image trueimage;//declaro la imagen de true
	public Image falseimage;//declaro la imagen de false

	//declaro la imagen de cada personaje
	public Image EnriqueImage;
	public Image SalvadorImage;
	public Image SantiagoImage;
	public Image JeffImage;
	bool tiempotrue;//declaro el tiempo como bool por si esta activo o falso
	// Use this for initialization
	void Start () {

		//empiezo el contador en 1
		cont = 1;
		//empiezo el tiempo en cero
		tiempo = 0;
		//el bool del tiempo lo inicio como falso y lo activare despues
		tiempotrue = false;
	}

	// Update is called once per frame
	void Update () {

		//imprimo en pantalla el tiempo que queda
		textoss.text =""+ tiempo;

		if (tiempo >= 1) {
			//si el tiempo es mayor a 1 las imagenes se apagaran dependiendo en que numero vallamos, por ejemplo si vamos en la primera, se apagara la del señor Enrique
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
		
			//el tiempo se volvera falso de nuevo
			tiempotrue = false;
			//el contador se sumara para pasar a la siguiente imagen
			cont++;
		}
		if (tiempotrue == true) {
			//si el bool del tiempo es true, se sumara tiempo a la variable tiempo
			tiempo = tiempo + Time.deltaTime;
		
		}
		
	}
	public void Enrique(){
		if (cont == 1) {
			//el metodo de Enrique solo funciona si vamos en el cont 1, osea si vamos en la primera pregunta, se arrojara valor true, se sumaran puntos
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			//en caso de que no vayamos en la primera pregunta, el contador de tiempo aun asi empezara a correr(Se habilitara), pero no se sumaran puntos y aparecera la magen de false
			falseimage.enabled = true;
			trueimage.enabled = false;}
		
		tiempotrue = true;
	}
	public void Salvador(){
		if (cont == 2) {
			//el metodo de Salvador solo funciona si vamos en el cont 2, osea si vamos en la primera pregunta, se arrojara valor true, se sumaran puntos
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			//en caso de que no vayamos en la primera pregunta, el contador de tiempo aun asi empezara a correr(Se habilitara), pero no se sumaran puntos y aparecera la magen de false
			falseimage.enabled = true;
			trueimage.enabled = false;}
		

		tiempotrue = true;
	}
	public void Santiago(){

		if (cont == 3) {
			//el metodo de Santiago solo funciona si vamos en el cont 3, osea si vamos en la primera pregunta, se arrojara valor true, se sumaran puntos
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			//en caso de que no vayamos en la primera pregunta, el contador de tiempo aun asi empezara a correr(Se habilitara), pero no se sumaran puntos y aparecera la magen de false
			falseimage.enabled = true;
			trueimage.enabled = false;}
		

		tiempotrue = true;
	}
	public void Jeff(){


		if (cont == 4) {
			//el metodo de Jeff solo funciona si vamos en el cont 4, osea si vamos en la primera pregunta, se arrojara valor true, se sumaran puntos
			trueimage.enabled = true;
			falseimage.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			//en caso de que no vayamos en la primera pregunta, el contador de tiempo aun asi empezara a correr(Se habilitara), pero no se sumaran puntos y aparecera la magen de false
			falseimage.enabled = true;
			trueimage.enabled = false;}
		

		tiempotrue = true;
	}

}

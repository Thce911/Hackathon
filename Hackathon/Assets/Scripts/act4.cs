using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class act4 : MonoBehaviour {
	//   ||


	//se declaran los InputFields/Textbox que se vana usar, y las imagenes de correcto e incorrecto de cada pregunta
	public InputField TB1;
	public Image true1;
	public Image false1;

	public InputField TB2;
	public Image true2;
	public Image false2;

	public InputField TB3;
	public Image true3;
	public Image false3;

	public InputField TB4;
	public Image true4;
	public Image false4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CHECARACT4(){

		//el metodo checaract4 evalua cada textbox
		if (TB1.text == "c" || TB1.text == "C") {
			//en caso de que el primero tenga escrito la letra "c" tanto en mayuscula o en minuscula, la imagen de la palomita se activara, la de falso se desaparecera si es que estaba activa y se sumaran puntos a la variable global
			true1.enabled = true;
			false1.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
		//en caso contrario, se activara la imagen de falso
			true1.enabled = false;false1.enabled = true;
		
		}

		if (TB2.text == "a" || TB2.text == "A") {
			//en caso de que el primero tenga escrito la letra "A" tanto en mayuscula o en minuscula, la imagen de la palomita se activara, la de falso se desaparecera si es que estaba activa y se sumaran puntos a la variable global
			true2.enabled = true;
			false2.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true2.enabled = false;false2.enabled = true;
			//en caso contrario, se activara la imagen de falso
		}

		if (TB3.text == "d" || TB3.text == "D") {
			//en caso de que el primero tenga escrito la letra "D" tanto en mayuscula o en minuscula, la imagen de la palomita se activara, la de falso se desaparecera si es que estaba activa y se sumaran puntos a la variable global
			true3.enabled = true;
			false3.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true3.enabled = false;false3.enabled = true;
				//en caso contrario, se activara la imagen de falso
			}

		if (TB4.text == "b" || TB4.text == "B") {
			//en caso de que el primero tenga escrito la letra "B" tanto en mayuscula o en minuscula, la imagen de la palomita se activara, la de falso se desaparecera si es que estaba activa y se sumaran puntos a la variable global
			true4.enabled = true;
			false4.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true4.enabled = false;false4.enabled = true;
					//en caso contrario, se activara la imagen de falso
				}
	
	
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class memoria : MonoBehaviour {
	int n1;
	int n2;
	string niA1;
	string niA2;
	string objectname;
	public Text label1;
	public Text label2;
	public Text label3;
	public Button boton1;
	public Button boton2;
	public Button boton3;
	public Button boton4;
	public Button boton5;
	public Button boton6;
	public Button boton7;
	public Button boton8;
	public Button boton9;
	public Button boton10;

	public Image imagen1;
	public Image imagen2;
	public Image imagen3;
	public Image imagen4;
	public Image imagen5;
	public Image imagen6;
	public Image imagen7;
	public Image imagen8;
	public Image imagen9;
	public Image imagen10;

	float contadortiempo;
	//public GameObject ccc;


	int click;
	// Use this for initialization
	void Start () {
		//timer = Time.time;
		n1 = 0;
		n2 = 0;
		click = 1;
		objectname = "";
		contadortiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (n1 == n2) {
			//label1.text = "aplicado" + n1 + "," + n2;
			switch (n1) {
			case 1:
				boton1.image.enabled = false;
				boton2.image.enabled = false;
				click = 1;	
				globalvariablesm.puntosglobales++;
				break;
			case 2:
				boton3.image.enabled = false;
				boton4.image.enabled = false;
				click = 1;	
				globalvariablesm.puntosglobales++;
				break;
			case 3:
				boton5.image.enabled = false;
				boton6.image.enabled = false;
				click = 1;	
				globalvariablesm.puntosglobales++;
				break;
			case 4:
				boton7.image.enabled = false;
				boton8.image.enabled = false;
				click = 1;	
				globalvariablesm.puntosglobales++;
				break;
			case 5:
				boton9.image.enabled = false;
				boton10.image.enabled = false;
				click = 1;	
				globalvariablesm.puntosglobales++;
				break;
			}
		} else {
			if (click == 3) {

				contadortiempo += Time.deltaTime;
				if (contadortiempo > 2f) {


					click = 1;
					n1 = 0;
					n2 = 0;
			
					switch (niA1) {
					case "i1":
						imagen1.enabled = false;
						break;
					case "i2":
						imagen2.enabled = false;
						break;
					case "i3":
						imagen3.enabled = false;
						break;
					case "i4":
						imagen4.enabled = false;
						break;
					case "i5":
						imagen5.enabled = false;
						break;
					case "i6":
						imagen6.enabled = false;
						break;
					case "i7":
						imagen7.enabled = false;
						break;
					case "i8":
						imagen8.enabled = false;
						break;
					case "i9":
						imagen9.enabled = false;
						break;
					case "i10":
						imagen10.enabled = false;
						break;
					}
					switch (niA2) {
					case "i1":
						imagen1.enabled = false;
						break;
					case "i2":
						imagen2.enabled = false;
						break;
					case "i3":
						imagen3.enabled = false;
						break;
					case "i4":
						imagen4.enabled = false;
						break;
					case "i5":
						imagen5.enabled = false;
						break;
					case "i6":
						imagen6.enabled = false;
						break;
					case "i7":
						imagen7.enabled = false;
						break;
					case "i8":
						imagen8.enabled = false;
						break;
					case "i9":
						imagen9.enabled = false;
						break;
					case "i10":
						imagen10.enabled = false;
						break;
					}
			
			
			
					contadortiempo = 0;
				}
			}
		}
		label1.text = "contador tiempo:" + contadortiempo;


		
	}
	public void memoriaMetodo(int ni){
		//label1.text += " "+a;
		if (click == 1) {
			
			n1 = ni;//a;


			click=2;
		} else {
			n2 = ni;//a;
			click = 3;

		}





	}
	public void memoriaMetodoString(string ni){
		if (click == 2) {
			niA1 = ni;
		} else {if (click == 3) {
				niA2 = ni;
				label3.text = "nia1=" + niA1 + ", nia2=" + niA2;
			} 
		}
		switch (ni) {
		case "i1":
			imagen1.enabled = true;
			break;
		case "i2":
			imagen2.enabled = true;
			break;
		case "i3":
			imagen3.enabled = true;
			break;
		case "i4":
			imagen4.enabled = true;
			break;
		case "i5":
			imagen5.enabled = true;
			break;
		case "i6":
			imagen6.enabled = true;
			break;
		case "i7":
			imagen7.enabled = true;
			break;
		case "i8":
			imagen8.enabled = true;
			break;
		case "i9":
			imagen9.enabled = true;
			break;
		case "i10":
			imagen10.enabled = true;
			break;



		}
	}
}

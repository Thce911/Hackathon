using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PUNTAJETOTAL : MonoBehaviour {
	public Text textpuntostotales;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//en este codigo mostraremos SIEMPRE en pantalla los puntos que llevamos acumulados
		textpuntostotales.text = "PUNTOS:" + globalvariablesm.puntosglobales;
	}
}

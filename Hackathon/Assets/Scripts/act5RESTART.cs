using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class act5RESTART : MonoBehaviour {
	//DECLARO ALS IMAGENES DE FALSO
	public Image F1;
	public Image F2;
	public Image F3;
	public Image F4;

	//DECLARO LAS IMAGENES DE VERDADERI
	public Image T1;
	public Image T2;
	public Image T3;
	public Image T4;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void REESTART(){
		//TODAS LAS DESHABILITO, LAS REINICIO, LAS APAGO
		F1.enabled = false;
		F2.enabled = false;
		F3.enabled = false;
		F4.enabled = false;

		T1.enabled = false;
		T2.enabled = false;
		T3.enabled = false;
		T4.enabled = false;

	
	
	}
}

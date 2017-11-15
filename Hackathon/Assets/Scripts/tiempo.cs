using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//RECUERDA PONER UN SHOOTER

public class tiempo : MonoBehaviour {
	public Text textoTIEMPO;
	bool cronometroactivo;
	public double tiempoquequeda;
	public Image falseimage;
	int TRUNCO;
	public Image trueimage;
	double ti;
	// Use this for initialization
	void Start () {
		TRUNCO = 10;
		cronometroactivo = true;
		tiempoquequeda = 10f;
		ti = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		TRUNCO = (int)tiempoquequeda;


		if (cronometroactivo == true) {
			//Time tiempo = Time.time;
			if (tiempoquequeda > 0) {
				ti = Time.deltaTime;
				tiempoquequeda -= ti;



				textoTIEMPO.text = "tiempo:" + TRUNCO;
				//ti = ti += Time.deltaTime;
			}
			if (tiempoquequeda < 0) {
				tiempoquequeda = 0;
				FALSO ();
		
		
		
		
			}
		}
	}
	public void FALSO(){
		//falseimage.enabled = true;
		falseimage.enabled=true;


	}
	public void Desactiva(){
		cronometroactivo = false;
	
	}


	//PONER LA OPCION DE TRY AGAIN
	public void TRYAGAIN(){
		cronometroactivo = true;
		tiempoquequeda = 10;
		falseimage.enabled = false;
		trueimage.enabled = false;
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Truefalse : MonoBehaviour {
	
	public Image trueimage;
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
}

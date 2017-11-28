using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PREGUNTAABIERTA1 : MonoBehaviour {
	//public InputField pelos;
	public Image correctoimage;
	public Image falsoimage;
	public InputField respuestaInput;


	//public InputField textbox;
	// Use this for initialization
	//   ||
	//
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Okmetodo ()
	{
		if (respuestaInput.text == "UNAM" || respuestaInput.text == "unam" ||respuestaInput.text == "Universidad Autonoma de Mexico" || respuestaInput.text == "Universidad Autónoma de México" || respuestaInput.text == "universidad autonoma de mexico") {
			correctoimage.enabled = true;
			falsoimage.enabled = false;
			globalvariablesm.puntosglobales++;
		
		} else {
			falsoimage.enabled = true;
			correctoimage.enabled = false;
		}
	

	}
}

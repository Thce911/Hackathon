using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class act4 : MonoBehaviour {
	//   ||
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
		if (TB1.text == "c" || TB1.text == "C") {
			true1.enabled = true;
			false1.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true1.enabled = false;false1.enabled = true;}

		if (TB2.text == "a" || TB2.text == "A") {
			true2.enabled = true;
			false2.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true2.enabled = false;false2.enabled = true;}

		if (TB3.text == "d" || TB3.text == "D") {
			true3.enabled = true;
			false3.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true3.enabled = false;false3.enabled = true;}

		if (TB4.text == "b" || TB4.text == "B") {
			true4.enabled = true;
			false4.enabled = false;
			globalvariablesm.puntosglobales++;
		} else {
			true4.enabled = false;false4.enabled = true;}
	
	
	
	}
}

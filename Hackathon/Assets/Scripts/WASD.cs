using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {
	bool arribaBool;
	bool abajoBool;

	bool izquierdaBool;
	bool derechaBool;
	// Use this for initialization
	void Start () {
		arribaBool = false;
		abajoBool = false;
		izquierdaBool = false;
		derechaBool = false;
		//; punto y coma esta junto a la Ñ
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, 2f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -2f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (2f, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (-2f, 0, 0);
		}



		if (arribaBool == true) {
			transform.Translate (0, 0, 2f);
		}
		if (abajoBool == true) {
			transform.Translate (0, 0, -2f);
		}
		if (izquierdaBool == true) {
			transform.Translate (2f, 0, 0);
		}
		if (derechaBool == true) {
			transform.Translate (-2f, 0, 0);
		}
	}

	//; punto y coma esta junto a la Ñ
	void OnTriggerEnter(Collider other)
	{
		MeshRenderer meshr;
		Light lighft;
		meshr=other.GetComponent<MeshRenderer> ();
		meshr.enabled = false;

		if (FogInitialize.FogTiles.Contains (other.name)) { //si el objeto ya están la lista de tiles
			//no hacer nada
		}  else { //si el objeto no están la lista de tiles
			FogInitialize.FogTiles.Add (other.name); //agregar tile a la colección
			string[] stringArray = FogInitialize.FogTiles.ToArray (); //convertir lista de tiles en array
			PlayerPrefs.SetString ("fogtiles", string.Join (",", stringArray)); //agregar a la memoria los tiles en 1 string a partir del array
		}
	}

}

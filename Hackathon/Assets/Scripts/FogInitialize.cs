using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogInitialize : MonoBehaviour {

	public static List<string> FogTiles = new List<string>(); //variable para guardar lista de tiles

	// Use this for initialization
	void Start () {

		FogTiles.Clear (); //limpiar lista dinámica de tiles para evitar redundancia
		if (PlayerPrefs.GetString ("fogtiles") == "") { //si no hay variable fogtiles en la memoria
			//no hacer nada
		}  else { //si hay variable fogtiles en la memoria
			//separar el string de la memoria y convertirlo en la lista de objetos
			foreach (string objetos in PlayerPrefs.GetString("fogtiles").Split(',')) {
				FogTiles.Add (objetos);
			}
		}

		foreach (Transform child in transform) {
			if (FogTiles.Contains (child.name)) { //si el tile está en la colección
				child.gameObject.SetActive (false); //desactivar tile
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

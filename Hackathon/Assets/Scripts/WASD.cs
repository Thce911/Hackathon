using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {


	//declaro los objetivos, necesito me digan los luygares a los que hay que ir, para ponerlos en el lugar correcto, por ejemplo "aulas 2", cada objetivo es un cuadrito en un lugar del mapa, que desaparece cuando es tocado por la esfera
	public MeshRenderer objetivo1;
	public MeshRenderer objetivo2;
	public MeshRenderer objetivo3;
	public MeshRenderer objetivo4;

	bool arribaBool;
	bool abajoBool;
	int objetivosalcanzados;   //contador de objetivos alcanzados, cuando tocas uno, aparece el otro
	bool izquierdaBool;
	bool derechaBool;
	// Use this for initialization
	void Start () {
		objetivosalcanzados = 0; //inicia en cero
		arribaBool = false;
		abajoBool = false;
		izquierdaBool = false;
		derechaBool = false;
		//; punto y coma esta junto a la Ñ
	}
	
	// Update is called once per frame
	void Update () {

		//movimiento con WASD
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


		//movimiento GPS
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
		meshr.enabled = false;   //desaparece cualquier objeto que toca, ya sea un objetivo o un fog
		if (other.tag == "objetivo") {   //si el objeto con el que colisiono es un objetivo, analiza cuantos lleva, para que aparesca el siguiente
			objetivosalcanzados++;
			switch (objetivosalcanzados) {
			case 1:  //lleva un objetivo, aparecera el segundo
				objetivo2.enabled = true;
				break;
			case 2: //lleva dos objetivos, aparecera el tercero
				objetivo3.enabled = true;
				break;
			case 3:
				objetivo4.enabled = true;
				break;}


		}

		//guarda los fogs desbloqueados en la memoria
		if (FogInitialize.FogTiles.Contains (other.name)) { //si el objeto ya están la lista de tiles
			//no hacer nada
		}  else { //si el objeto no están la lista de tiles
			FogInitialize.FogTiles.Add (other.name); //agregar tile a la colección
			string[] stringArray = FogInitialize.FogTiles.ToArray (); //convertir lista de tiles en array
			PlayerPrefs.SetString ("fogtiles", string.Join (",", stringArray)); //agregar a la memoria los tiles en 1 string a partir del array
		}
	}

}

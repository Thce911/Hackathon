using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acercate : MonoBehaviour {
	public GameObject estecubo;
	public Transform player;
	public Transform vida;
	public Text texto;
	float x;
	float puntos;
	// Use this for initialization
	void Start () {
		puntos = 10f;
		texto.text = "puntos:" + puntos+ "/"+vida.localScale.x;
		x = vida.localScale.x;
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (transform.position.x < player.position.x) {
			transform.Translate (0.2f, 0, 0);}
		if (transform.position.x > player.position.x) {
			transform.Translate (-0.2f, 0, 0);}
		if (transform.position.z < player.position.z) {
			transform.Translate (0, 0, 0.2f);}
		if (transform.position.z > player.position.z) {
			transform.Translate (0, 0, -0.2f);}*/
		texto.text = "puntos:" + puntos+ "/"+vida.localScale.x;
	}
	void OnTriggerEnter(Collider other){
		//if (other.tag == "bala") {
		if (puntos > 0) {
			puntos--;
			x -= 0.1f;

			vida.localScale = new Vector3 (x, 0.33f, 0.33f);
		}
		if (puntos <= 0) {
			
		puntos = 100f;
		GameObject instantiatedProjectile = Instantiate (estecubo,new Vector3(3f,0,3f), transform.rotation) as GameObject;
			instantiatedProjectile.transform.localScale = new Vector3 (3f, 3f, 3f);
			transform.position = new Vector3 (100f, 100f, 100f);


	}
	
	
 }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Ports;
using UnityEngine.UI;

public class move : MonoBehaviour {
	public string COMn;
	public Transform manomueve;
	public Transform dedo1;
	public Transform dedo2;
	public Transform dedo3;
	public Transform dedo4;
	public Transform dedo5;

	//disminuir la rotacion del pinky en "y"

	public Text text;
	public Text texto2;
	float xmano;
	float ymano;
	float zmano;
	float flexmano;


	Quaternion vec1;// = dedo1.rotation;
	Quaternion  vec2;// = dedo2.rotation;
	Quaternion  vec3;// = dedo3.rotation;
	Quaternion  vec4;// = dedo4.rotation;
	Quaternion  vec5;// = dedo5.rotation;



	Quaternion quar1 = new Quaternion (1000, 1000, 1000, 1000);
	Quaternion quar2 = new Quaternion (1000, 1000, 1000, 1000);
	Quaternion quar3 = new Quaternion (1000, 1000, 1000, 1000);
	Quaternion quar4 = new Quaternion (1000, 1000, 1000, 1000);
	Quaternion quar5 = new Quaternion (1000, 1000, 1000, 1000);


	float xf=0;float yf=0;float zf=0;float flexf=0;
	SerialPort sp = new SerialPort ("COM7", 9600);
	float valor;
	// Use this for initialization
	void Start () {
		
		vec1 = dedo1.rotation;
		  vec2 = dedo2.rotation;
		  vec3 = dedo3.rotation;
		 vec4 = dedo4.rotation;
		  vec5 = dedo5.rotation;

		sp.Open ();
		valor = 920f;
		sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (0.3f, 0, 0);
		}


		if (Input.GetKeyDown (KeyCode.Q)) {
			quar1 = dedo1.rotation;
			quar2 = dedo2.rotation;
			quar3 = dedo3.rotation;
			quar4 = dedo4.rotation;
			quar5 = dedo5.rotation;
		
		
		
		}


		if (sp.IsOpen) {
			try{
				//texto2.text=sp.ReadLine();
				string l1=sp.ReadLine();
				string l2=sp.ReadLine();
				string l3=sp.ReadLine();
				string l4=sp.ReadLine();


			
				//string total=sp.ReadLine();
				//texto2.text=total+"ff";  //ESTE SI JALA

				float l1f=0;float l2f=0;float l3f=0; float l4f=0;
				//string xs=""; string ys=""; string zs=""; string flexs="";
				int comas=0;
				////
				int ncomas = 0;
				string comass="";
				//string palabra=total+"k";
				l1f=float.Parse(l1);
				l2f=float.Parse(l2);
				l3f=float.Parse(l3);
				l4f=float.Parse(l4);



				/* x y z f
				 * f x y z
				 * z f x y
				 * y z f x
				*/

				//L1 ES ACELERACION
				if(l4f>=700f){
					xf=l1f;
					yf=l2f;
					zf=l3f;
					flexf=l4f;

				}else{
					if(l1f>=700f){
						flexf=l1f;
						xf=l2f;
						yf=l3f;
						zf=l4f;

					}else{
						if(l2f>700f){
							zf=l1f;
							flexf=l2f;
							xf=l3f;
							yf=l4f;



						}else{
							if(l3f>=700){
								yf=l1f;
								zf=l2f;
								flexf=l3f;
								xf=l4f;


							}


						}


					}


				}

				texto2.text=xf+","+yf+","+zf+","+flexf;
				//manomueve.Translate(xf/1000,yf/1000,zf/1000);




			}//"Byte:"+sp.ReadByte()+",Char:"+sp.ReadChar()+"Line:"+sp.ReadLine()
			catch(System.Exception){
			}
		
		}

		if (flexf >= 890f) {
			text.text = "S";
			//dedo1.Translate (8f, 0, 0);
			//transform.localScale = new Vector3 (1f, 3f, 1f);


			//if (dedo1.rotation > quar1) {
				dedo1.Rotate (5f, 0, 0);
		//	}
		//	if (dedo2.rotation > quar2) {
				dedo2.Rotate (0, 5f,0);
		//	}
			//if (dedo3.rotation > quar3) {
				dedo3.Rotate (0, 0, 5f);
		//	}
			//if (dedo4.rotation > quar4) {
				dedo4.Rotate (5f, 5f, 0);
		//	}
			//if (dedo5.rotation > quar5) {
				dedo5.Rotate (0, -0.5f, 0);
		//	}
		} else {
			if (valor > 800) {
				//transform.localScale = new Vector3 (1f, 1f, 1f);


			}
			if (dedo1.rotation != vec1) {
				dedo1.Rotate(0,0.2f,0);}
			if (dedo2.rotation != vec2) {
				dedo2.Rotate(0,0.2f,0);}
			if (dedo3.rotation != vec3) {
				dedo3.Rotate(0,0.2f,0);}
			if (dedo4.rotation != vec4) {
				dedo4.Rotate(0,0.2f,0);}
			if (dedo5.rotation != vec5) {
				dedo5.Rotate(0,0.2f,0);}
			/*dedo1.rotation = vec1;
			dedo2.rotation = vec2;
			dedo3.rotation = vec3;
			dedo4.rotation = vec4;
			dedo5.rotation = vec5;
*/
		}
	}//termina update

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccelerometerInput : MonoBehaviour {


	private bool gyroEnabled;
	private Gyroscope gyro;

	private GameObject cameraContainer;
	private Quaternion rot;

	private void Start (){
		cameraContainer = new GameObject ("Camera Container");
		cameraContainer.transform.position = transform.position;
		transform.SetParent (cameraContainer.transform);

		gyroEnabled = EnableGyro();
	}

	private bool EnableGyro(){

		if(SystemInfo.supportsGyroscope){
			gyro = Input.gyro;
			gyro.enabled = true;

			cameraContainer.transform.rotation = Quaternion.Euler (90F, 90F, 90F);
			rot = new Quaternion (0,0,1,0);

			return true;
		}
		return false;
	}


	// Update is called once per frame
	void Update() 
	{
		GameObject.Find("north").transform.Translate(0, Input.acceleration.y, -Input.acceleration.z);
		GameObject.Find("varx").GetComponent<Text>().text = Input.acceleration.x.ToString();
		GameObject.Find("vary").GetComponent<Text>().text = Input.acceleration.y.ToString();
		GameObject.Find("varz").GetComponent<Text>().text = Input.acceleration.z.ToString();
		GameObject.Find("gyx").GetComponent<Text>().text = transform.rotation.ToString();
		//GameObject.Find("gyy").GetComponent<Text>().text = Input.acceleration.y.ToString();
		//GameObject.Find("gyz").GetComponent<Text>().text = Input.acceleration.z.ToString();

		if (gyroEnabled)
		{
			transform.localRotation = gyro.attitude * rot;
		}

	}
}

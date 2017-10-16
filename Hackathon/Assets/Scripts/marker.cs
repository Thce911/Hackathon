using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marker : MonoBehaviour {

	//Gyro
	private Gyroscope gyro;
	private GameObject cameraContainer;
	private Quaternion rotation;


	//cam
	private WebCamTexture cam;
	public RawImage background;
	public AspectRatioFitter fit;

	private bool arReady = false;

	private void Start()
	{
		//Checking if is supported Gyroscope

		if(!SystemInfo.supportsGyroscope)
		{
				Debug.Log("This device does not have Gyroscope");
				return;
		}

		//Back Camera

		for(int i = 0; i< WebCamTexture.devices.Length; i++)
		{
			if (!WebCamTexture.devices[i].isFrontFacing)
			{
				cam = new WebCamTexture(WebCamTexture.devices[i].name, Screen.width, Screen.height);
				break;
			}
		}


		if (cam == null)
		{
			Debug.Log("This device does not have back camera");
			return;
		}

		cameraContainer = new GameObject("Camera Container");
		cameraContainer.transform.position = transform.position;
		transform.SetParent(cameraContainer.transform);

		gyro = Input.gyro;
		gyro.enabled = true;

		cam.Play();
		background.texture = cam;

		arReady = true;

	}

	private void Update()
	{
		if(arReady)
		{
			float ratio = (float)cam.width / (float)cam.height;
			fit.aspectRatio =ratio;

			float scaleY=cam.videoVerticallyMirrored ? -1.0f : 1.0f;
			background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

			int orient = -cam.videoRotationAngle;
			background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);

			transform.localRotation = gyro.attitude * rotation;
		}
	}




}

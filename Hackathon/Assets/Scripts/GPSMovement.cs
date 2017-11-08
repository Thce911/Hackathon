using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPSMovement : MonoBehaviour {

	public LocationInfo posicionGPS;

	void Update()
	{
		posicionGPS = Input.location.lastData;

		float y = latitudY (Input.location.lastData.latitude);
		float x = longitudX (Input.location.lastData.longitude);

		this.transform.localPosition = new Vector3 (x, y);

	}

	float latitudY(double lat){
		//-100.2969, 25.6478; -100.2835, 25.6554
		lat= (((lat) - 25.6478)) * 16447.36842105263;
		double y = lat;

		return (float)y;
	}

	float longitudX (double lon){

		lon = (((lon * -1) - 100.2969) * -1) * 9328.358208955224;
		double x = lon;

		return (float)x;
	}
}

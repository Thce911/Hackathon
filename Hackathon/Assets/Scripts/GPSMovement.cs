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

		this.transform.localPosition = new Vector2 (x, y);

	}

	float latitudY(double lat){
		//-100.29373, 25.648; -100.28651, 25.6547
		lat= (((lat) - 25.648)) * 746.2686567164179;
		double y = lat - 2.5;

		return (float)y;
	}

	float longitudX (double lon){

		lon = (((lon * -1) - 100.29373) * -1) * 692.5207756232687;
		double x = lon - 2.5;

		return (float)x;
	}
}

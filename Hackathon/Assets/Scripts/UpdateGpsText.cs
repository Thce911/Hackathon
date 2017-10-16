using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGpsText : MonoBehaviour {

	public Text Lat;
	public Text Lon;

	public float lat1;
	public float lon1;

	public float lat2;
	public float lon2;

	public float Lond;
	public float Latd;
	public float grado;
	public float dist, dist2;
	public float fdist;

	public Text distance;


	private void Update()
	{
		Lat.text = "Lat:" + GPS.Instance.latitude.ToString();
		Lon.text = "Lon:" + GPS.Instance.longitude.ToString();

		lat1 = GPS.Instance.latitude;
		lon1 = GPS.Instance.longitude;

		float lat2 = 25.653740f;
		float lon2 = -100.292520f;

		Lond=(lon2-lon1)*(lon2-lon1);
		Latd=(lat2-lat1)*(lat2-lat1);

		grado = Mathf.Sqrt(Lond+Latd);
		dist = grado * 10000;
		dist2 = dist / 90;
		fdist = dist2 * 1000;

	
		GameObject.Find("distance").GetComponent<Text>().text = fdist.ToString()+"m";


	}
}

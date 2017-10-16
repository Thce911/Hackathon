using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
	
	public GameObject circle1;

	void Update()
	{
		circle1.transform.Rotate(0,0,1);
	}


}

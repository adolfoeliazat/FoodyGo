using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGPSCompassController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.compass.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Orient an Object to POint to magnetic north and adjust map reversal
		var heading = 180 + Input.compass.magneticHeading;
		var rotation = Quaternion.AngleAxis(heading,Vector3.up);
		transform.rotation=Quaternion.Slerp(transform.rotation,rotation, Time.fixedTime*.001f);
	}
}

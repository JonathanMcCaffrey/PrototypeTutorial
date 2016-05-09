using UnityEngine;
using System.Collections;

public class TiltControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.acceleration.x, -Input.acceleration.z, 0);


	}
}

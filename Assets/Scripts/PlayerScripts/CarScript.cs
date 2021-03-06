﻿using System.Collections;
using UnityEngine;

public class CarScript : MonoBehaviour {

	public float rospeed = 90.0f;
	public float acceleration = 0.0f;
	public float revspeed = 0.0f;

	void Update () {

		if (Input.GetKey (KeyCode.W)) {

			Debug.Log ("Key W Pressed");
			transform.Translate (new Vector3 (0, 0, acceleration * Time.deltaTime));
			if (acceleration < 100)
				acceleration += 2;
		} else

			Debug.Log ("Nothing Pressed");
		transform.Translate (new Vector3 (0, 0, acceleration * Time.deltaTime));

		if (acceleration > 0)
			acceleration -= 1;

		if (Input.GetKey (KeyCode.S)) {
			Debug.Log ("Key S Pressed.");
			transform.Translate (new Vector3 (0, 0, revspeed * Time.deltaTime));
			if (revspeed > -20)
				revspeed = -20;
		} else

			Debug.Log ("Not Reversing");
		transform.Translate (new Vector3 (0, 0, revspeed * Time.deltaTime));

		if (revspeed < 0)
			revspeed += 1;

		if (Input.GetKey (KeyCode.D)) {
			Debug.Log ("Key D Pressed");
			transform.Rotate (new Vector3 (0, rospeed * Time.deltaTime, 0));
		} else if (Input.GetKey (KeyCode.A)) {
			Debug.Log ("Key A Pressed.");
			transform.Rotate (new Vector3 (0, -rospeed * Time.deltaTime, 0));
		}

	}

	void OnTriggerStay (Collider other) {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector3 (0, 0, -acceleration * Time.deltaTime));
			if (acceleration > 5)
				acceleration = 5;
		} else if (Input.GetKeyUp (KeyCode.W)) {
			acceleration = 0;
		}
	}

	void OnTriggerExit (Collider other) {
		acceleration = +1;
	}

}
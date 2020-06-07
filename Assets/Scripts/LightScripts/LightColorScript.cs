using System.Collections;
using UnityEngine;

public class LightColorScript : MonoBehaviour {

	public Light lt;

	// Use this for initialization

	void Start ()

	{

		lt = GetComponent<Light> ();

		lt.color = Color.red;

	}

	// Update is called once per frame

	void Update () {

		if (Input.GetKey (KeyCode.B))

		{

			lt.color = Color.red;

		}

		if (Input.GetKey (KeyCode.N))

		{

			lt.color = Color.blue;

		}

	}
}
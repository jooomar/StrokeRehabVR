using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveClouds : MonoBehaviour {
	public float cloudSpeed = 0.001f;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * cloudSpeed);
	}
}

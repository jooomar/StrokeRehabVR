using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postureManager : MonoBehaviour {

	public static bool palm = false, elbow = false;

	float duration = 0;

	public float HoldDuration = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (palm && elbow) {
			duration += Time.deltaTime;
			if (duration > HoldDuration) {
				Debug.Log ("Done!");
				duration = 0;
			}

		}
	}
}

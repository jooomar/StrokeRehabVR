using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDetection : MonoBehaviour {
	public bool isPalm, isElbow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
 
		if (isElbow) {
			postureManager.elbow = true;
			Debug.Log ("****************elbow in position!");
		} else if (isPalm) {
			postureManager.palm = true;
			Debug.Log ("****************palm in position!");
		}
	}

	void OnTriggerEnxit(Collider col){
		if (isElbow) {
			postureManager.elbow = false;
		} else if (isPalm) {
			postureManager.palm = false;
		}
	}

}

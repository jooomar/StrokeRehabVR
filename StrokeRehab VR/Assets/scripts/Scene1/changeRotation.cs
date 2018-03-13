using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.rotation = Quaternion.LookRotation (gameObject.transform.forward, gameObject.transform.forward);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upperArmManager : MonoBehaviour {

	public GameObject cam, elbow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.rotation = Quaternion.LookRotation (elbow.transform.position - cam.transform.position);
		gameObject.transform.position = (elbow.transform.position - cam.transform.position);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketPosManager : MonoBehaviour {

	public Vector3 offset;
	public GameObject HMD;
	// Use this for initialization
	void Start () {
		gameObject.transform.position = HMD.transform.position + offset;
	}
}

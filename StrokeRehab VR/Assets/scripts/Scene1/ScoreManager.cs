using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {


	public int localScore;


	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag.Equals ("bread")) {
			disableVSync.tempScore = localScore;
		}
	}



	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckPositioning : MonoBehaviour {

	float randomCoordinate(){
		float Position = Random.Range(-4.9f,4.9f);
		return Position;
	}

	void randomPosition(GameObject duck){
		duck.transform.position = new Vector3 (randomCoordinate (), 1.0f, randomCoordinate ());
	}
		
	// Update is called once per frame
	// Use this for initialization
	void Start () {
		randomPosition (gameObject);
	}

}

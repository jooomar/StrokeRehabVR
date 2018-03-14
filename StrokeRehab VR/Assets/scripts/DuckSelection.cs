using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DuckSelection : MonoBehaviour {
	public GameObject Duck1; 
	public GameObject Duck2;
	public GameObject Duck3;
	public GameObject Duck4;
	public GameObject Duck5;
	DuckMovement dm;
	GameObject g;

	void Start () {
		int duckNumber = Random.Range (1, 6);
		if (duckNumber == 1) {
			g = Duck1;
			dm = g.GetComponent<DuckMovement> ();
 
			/*
			selected = true; 
		} else if (duckNumber == 2) {
			g = Duck2;
			dm = g.GetComponent<DuckMovement> ();
			dm.selected = true; 
		} else if (duckNumber == 3) {
			g = Duck3;
			dm = g.GetComponent<DuckMovement> ();
			dm.selected = true; 
		} else if (duckNumber == 4) {
			g = Duck4;
			dm = g.GetComponent<DuckMovement> ();
			dm.selected = true; 
		} else {
			g = Duck5;
			dm = g.GetComponent<DuckMovement> ();
			dm.selected = true; 
		}

	*/
		}
	}
}

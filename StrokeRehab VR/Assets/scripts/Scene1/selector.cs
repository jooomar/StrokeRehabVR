using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {

	public GameObject droppedBread = null;
	public GameObject[] ducks;
	// Use this for initialization
	void Start () {
		ducks = GameObject.FindGameObjectsWithTag ("duck");
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag.Equals ("bread")) {
			droppedBread = col.gameObject;
		

			int rand = Random.Range (0, ducks.Length - 1);
			Vector3 temp = new Vector3 (col.gameObject.transform.position.x, ducks [rand].transform.position.y, col.gameObject.transform.position.z);
			ducks [rand].GetComponent<DuckMovement> ().targetPosition = temp;

			ducks [rand].GetComponent<DuckMovement> ().Active = true;
		}
	}
}

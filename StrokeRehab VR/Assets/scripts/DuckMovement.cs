using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour {

	Vector3 startPosition;
	public bool Active = false;
	public float speed = 5;
	public Vector3 targetPosition;

	public bool ret = false;
	void Start(){
		startPosition = gameObject.transform.position;
	}

	void Update(){
		if (Active) {
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, targetPosition, Time.deltaTime * speed);
			gameObject.transform.LookAt (targetPosition);
		} else if (ret) {
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, startPosition, Time.deltaTime * speed);
			gameObject.transform.LookAt (startPosition);
		}
	}
		
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag.Equals ("bread")) {
			//set animator
			Destroy(col.gameObject);
			Active = false;
			ret = true;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour {

	Vector3 startPosition;
	public bool Active = false;
	public bool ret = false;
	bool tempMovement = false;
	public float speed = 5;
	public Vector3 targetPosition;

	public Animator duckAnim;

	public Vector3 tempPos;
	public disableVSync disVS;

	void Start(){
		startPosition = gameObject.transform.position;
		tempPos = startPosition;
		Invoke ("generateRandomPosition", Random.Range(1,3));
	}

	void Update(){
		if (Active) {
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, targetPosition, Time.deltaTime * speed);
			gameObject.transform.LookAt (targetPosition);
		} else if (ret) {
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, startPosition, Time.deltaTime * speed);
			gameObject.transform.LookAt (startPosition);
		} else if (tempMovement) {
		//	Debug.Log ("*********************");
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, tempPos, Time.deltaTime * speed);
			gameObject.transform.LookAt (tempPos);
		}

	}
		
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag.Equals ("bread")) {
			//set animator
			duckAnim.SetBool("swimming", true);
			Destroy(col.gameObject);
			disableVSync.Score += disableVSync.tempScore;
			disVS.UpdateScore ();
			Active = false;
			ret = true;
		}


	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag.Equals ("start")) {
			//set animator
			tempMovement = true;
			Active = false;
			ret = false;
//			Debug.Log("dfgdfgdg");
			duckAnim.SetBool("swimming", false);
		}
	}

	void generateRandomPosition(){
		int x = Random.Range (-3, 3);
		int z = Random.Range (-3, 3);

		tempPos = startPosition + new Vector3 (x, 0, z);
		Invoke ("generateRandomPosition", Random.Range(1,3));

	}
		
}

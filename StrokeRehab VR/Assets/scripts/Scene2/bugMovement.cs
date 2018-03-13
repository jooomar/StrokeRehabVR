using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugMovement : MonoBehaviour {

	public bool isWaiting = false;
	public GameObject[] points;
	int curr = 0;
	public float speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((gameObject.transform.position - points [curr].transform.position).sqrMagnitude < 1) {
			curr++;
		}
		if (!isWaiting) {
			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, points [curr].transform.position, Time.deltaTime * speed);
		}
	}
}

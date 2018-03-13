using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugManager : MonoBehaviour {

	public static bool isActive;
	public GameObject bug;
	public GameObject spawnPoint;
	// Use this for initialization

	void Start () {
		
	}

	public void instantiateBug(){
		GameObject.Instantiate(bug, spawnPoint.transform.position , Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		
	}
}

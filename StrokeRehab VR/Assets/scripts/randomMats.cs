using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMats : MonoBehaviour {

	public Color[] colors;
	public GameObject forearm;
	void Start(){
		int x = Random.Range (0, colors.Length);

		gameObject.GetComponent<Renderer> ().material.color = colors [x];
		if(forearm!=null)
		forearm.GetComponent<Renderer> ().material.color = colors [x];
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {


	public int localScore;
	AudioSource source;

	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag.Equals ("bread")) {
			disableVSync.tempScore = localScore;
			source.PlayOneShot (source.clip);
		}
	}



	// Update is called once per frame
	void Update () {
		
	}
}

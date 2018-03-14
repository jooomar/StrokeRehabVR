using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckSoundManager : MonoBehaviour {

	public GameObject soundManager;
	AudioSource source;

	int curr = 0;

	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		Invoke ("playSound", Random.Range (2, 5));
	}

	void playSound(){
		source.clip = soundManager.GetComponent<soundManager> ().clips [curr];
		curr = (curr + 1) % 4;
		source.PlayOneShot (source.clip);
		Invoke ("playSound", 10);
	}

}

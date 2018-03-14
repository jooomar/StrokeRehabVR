using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disableVSync : MonoBehaviour {

	public static int Score = 0;
	public static int tempScore;
	public TextMesh scoreTextUI;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = -1;
	}

	public void UpdateScore(){
		scoreTextUI.text = "Score: " + Score;
		check ();
	}

	void check(){
		if (Score >= 20 && Score - tempScore <= 20) {
			basket.transform.Translate (Vector3.up * 0.08f);
		}else if (Score >= 40 && Score - tempScore <= 40) {
			basket.transform.Translate (Vector3.up * 0.08f);
		}else if (Score >= 60 && Score - tempScore <= 60) {
			basket.transform.Translate (Vector3.up * 0.08f);
		}
	}

	public GameObject basket;

	void increase(){
		basket.transform.position = basket.transform.position + Vector3.up;
	}


}

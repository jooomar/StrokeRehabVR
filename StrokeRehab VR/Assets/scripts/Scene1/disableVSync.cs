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
	}

}

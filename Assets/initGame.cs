using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("nbLives", 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

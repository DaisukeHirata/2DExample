using UnityEngine;
using System.Collections;

public class initGame : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt ("score", 0);
		PlayerPrefs.SetInt ("nbLives", 3);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

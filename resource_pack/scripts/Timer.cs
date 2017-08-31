using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
	float timer;
	int seconds;

	// Use this for initialization
	void Start () {
		timer = 30;
		seconds = 0;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		seconds = (int)(timer);
		GameObject.Find ("timerUI").GetComponent<Text> ().text = "Time: " + seconds;
		if (seconds <= 0) 
		{
			int nbLives;
			GameObject.Find ("player").GetComponent<DetectCollision> ().DecreaseLives ();

		}
	}
}

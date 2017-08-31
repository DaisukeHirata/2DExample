using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
	void Update () {
        timer -= Time.deltaTime;
        seconds = (int)(timer);
        GameObject.Find("timerUI").GetComponent<Text>().text = "time:" + seconds;
		if (seconds <= 0) {
            GameObject.Find("player").GetComponent<DetectCollision>().DecreaseLives();
        }
	}
}

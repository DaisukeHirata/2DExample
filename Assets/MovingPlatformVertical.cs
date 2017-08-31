using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformVertical : MonoBehaviour {

    float timer, direction;

	// Use this for initialization
	void Start () {
        timer = 0;
        direction = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        transform.Translate(Vector3.up * direction);
        if (timer >= 1) {
            direction *= -1;
            timer = 0;
        }
	}
}

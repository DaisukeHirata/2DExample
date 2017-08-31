using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformHorizontal : MonoBehaviour {

    float timer, direction;

	// Use this for initialization
	void Start () {
        timer = 0;
        direction = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        transform.Translate(Vector3.right * direction);
        if (timer >= 1) {
            direction *= -1;
            timer = 0;
        }
	}
}

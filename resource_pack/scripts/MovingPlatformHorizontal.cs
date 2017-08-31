using UnityEngine;
using System.Collections;

public class MovingPlatformHorizontal : MonoBehaviour {

	float direction, timer;
	// Use this for initialization
	void Start () {
		direction = 0.1f;
		timer  = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		transform.Translate (Vector3.right * direction);
		if (timer >= 1) 
		{
			direction *= -1;
			timer = 0.0f;

		}
	
	}
}

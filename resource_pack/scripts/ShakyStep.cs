using UnityEngine;
using System.Collections;

public class ShakyStep : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D> ().isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		GetComponent<Rigidbody2D> ().isKinematic = false;
		Destroy (gameObject, 3.0f);
	}
}

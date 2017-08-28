using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour {

	// Use this for initialization
    void Start () {
	    
    }
	
	// Update is called once per frame
    void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.collider.gameObject.tag;

        if (tag == "pick_me") {
            Destroy(collision.collider.gameObject);
        }

        if (tag == "avoid_me") {
            Destroy(collision.collider.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

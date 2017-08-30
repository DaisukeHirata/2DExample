using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour {

    int score;
    int nbCoinsCollectedPerLevel;

	// Use this for initialization
    void Start () {
        nbCoinsCollectedPerLevel = 0;
    }
	
	// Update is called once per frame
    void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.collider.gameObject.tag;

        if (tag == "pick_me") {
            Destroy(collision.collider.gameObject);
            score++;
            nbCoinsCollectedPerLevel++;
            if (SceneManager.GetActiveScene().name == "level1" && nbCoinsCollectedPerLevel >= 5) {
                SceneManager.LoadScene("level2");
    		}
            print("score" + score);
        }

        if (tag == "avoid_me") {
            Destroy(collision.collider.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (tag == "reStarter") {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (tag == "endOfLevelTwo") {
            SceneManager.LoadScene("win");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour {

    public AudioClip collect, hurt;

    int score;
    int nbLives;
    int nbCoinsCollectedPerLevel;

	// Use this for initialization
    void Start () {
        updateUI();
        nbCoinsCollectedPerLevel = 0;
    }
	
	// Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.M))
		{
			GetComponent<AudioSource>().mute = !GetComponent<AudioSource>().mute;
            GameObject rainbows = GameObject.Find("Rainbows");
            rainbows.GetComponent<AudioSource>().mute = !rainbows.GetComponent<AudioSource>().mute;
		}
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.collider.gameObject.tag;

        if (tag == "pick_me") {
            Destroy(collision.collider.gameObject);
            GetComponent<AudioSource>().clip = collect;
			GetComponent<AudioSource>().Play();
            score = PlayerPrefs.GetInt("score");
            score++;
            PlayerPrefs.SetInt("score", score);
            nbCoinsCollectedPerLevel++;
            if (SceneManager.GetActiveScene().name == "level1" && nbCoinsCollectedPerLevel >= 5) {
                SceneManager.LoadScene("level2");
    		}
            print("score" + score);
        }

        if (tag == "avoid_me" || tag == "reStarter") {
            Destroy(collision.collider.gameObject);
            GetComponent<AudioSource>().clip = hurt;
			GetComponent<AudioSource>().Play();
			nbLives = PlayerPrefs.GetInt("nbLives");
            nbLives--;
            PlayerPrefs.SetInt("nbLives", nbLives);
            if (nbLives >= 0)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            else
                SceneManager.LoadScene("lose");
            print("lives" + nbLives);
        }

        if (tag == "endOfLevelTwo") {
            SceneManager.LoadScene("win");
        }

        updateUI();
    }

    void updateUI()
    {
		score = PlayerPrefs.GetInt("score");
		nbLives = PlayerPrefs.GetInt("nbLives");
        GameObject.Find("scoreUI").GetComponent<Text>().text = "Score:" + score;
        GameObject.Find("livesUI").GetComponent<Text>().text = "Lives:" + nbLives;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour {
	int score, nbLives, nbCoinsCollectedPerLevel;
	public AudioClip collect, hurt;
	bool isMovingPlatform = false;

	// Use this for initialization
	void Start () {

		updateUI ();
		nbCoinsCollectedPerLevel = 0;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D coll)
	{
		string tag = coll.collider.gameObject.tag;

		if (tag == "moving_platform") 
		{
			transform.parent = coll.gameObject.transform;
			isMovingPlatform = true;
		}

		if (tag == "pick_me") 
		{
			GetComponent<AudioSource> ().clip = collect;
			GetComponent<AudioSource> ().Play ();
			Destroy (coll.collider.gameObject);
			//score++;
			score = PlayerPrefs.GetInt("score");
			score++;
			PlayerPrefs.SetInt ("score", score);
			nbCoinsCollectedPerLevel++;
			if (SceneManager.GetActiveScene ().name == "level1" && nbCoinsCollectedPerLevel >= 5) 
			{
				SceneManager.LoadScene ("level2");
			}
			//print ("score" + score);
			updateUI();
		}
		if (tag == "avoid_me" || tag == "reStarter") 
		{

			GetComponent<AudioSource> ().clip = hurt;
			GetComponent<AudioSource> ().Play ();
			Destroy (coll.collider.gameObject);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			DecreaseLives ();

			//print ("Lives:" + nbLives);
			updateUI();
		}
		/*if (tag == "reStarter") 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}*/

		if (tag == "endOfLevel2") 
		{
			SceneManager.LoadScene ("win");
		}
	}


	void updateUI()
	{
		score = PlayerPrefs.GetInt ("score");
		nbLives = PlayerPrefs.GetInt ("nbLives");
		GameObject.Find ("scoreUI").GetComponent<Text>().text = "Score:" + score;
		GameObject.Find ("livesUI").GetComponent<Text>().text = "Lives:" + nbLives;

	}


	public void DecreaseLives()
	{

		nbLives = PlayerPrefs.GetInt ("nbLives");
		nbLives--;
		PlayerPrefs.SetInt ("nbLives", nbLives);
		if (nbLives >= 0)
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		else
			SceneManager.LoadScene ("lose");
		

	}

	void OnCollisionExit2D (Collision2D coll)
	{
		if (isMovingPlatform) 
		{
			transform.parent = null;
			isMovingPlatform = false;
		}

	}
	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.name == "magic_door_entrance") 
		{
			transform.position = GameObject.Find ("magic_door_exit").transform.position;
		}

	}
}

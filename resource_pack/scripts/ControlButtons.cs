using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ControlButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string currentScene = SceneManager.GetActiveScene ().name;
		if (currentScene == "win" || currentScene == "lose") 
		{
			GameObject.Find ("scoreUI").GetComponent<Text> ().text = "";
			GameObject.Find ("livesUI").GetComponent<Text> ().text = "";
			GameObject.Find ("timerUI").GetComponent<Text> ().text = "";

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void startLevel1()
	{
		SceneManager.LoadScene ("level1");
	}
	public void loadSplashScreen()
	{
		SceneManager.LoadScene ("splashScreen");
	}
}

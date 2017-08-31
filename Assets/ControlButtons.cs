using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlButtons : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        print("ControleButtons start");
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "win" || currentScene == "lose") {
            GameObject.Find("scoreUI").GetComponent<Text>().text = "";
			GameObject.Find("livesUI").GetComponent<Text>().text = "";
			GameObject.Find("timerUI").GetComponent<Text>().text = "";
		}
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startLevel1() 
    {
        SceneManager.LoadScene("level1");
	}

    public void loadSplashScreen()
    {
		SceneManager.LoadScene("splashScreen");
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

		int nbUIs = GameObject.FindGameObjectsWithTag ("playerUI").Length;
		//if (SceneManager.GetActiveScene ().name == "level1" && nbUIs > 1)
		//Destroy (GameObject.FindGameObjectsWithTag ("playerUI") [0]);
		if (FindObjectsOfType (GetType ()).Length > 1) Destroy (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
}

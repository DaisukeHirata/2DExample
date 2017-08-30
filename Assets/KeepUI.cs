using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int nbUIs = GameObject.FindGameObjectsWithTag("player_ui").Length;
        if (nbUIs > 1) {
            Destroy(gameObject);
        }
        //if (FindObjectsOfType(GetType()).Length > 1) Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
}

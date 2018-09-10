using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour {

    public GameObject button, text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(0);
        button.SetActive(false);
        text.SetActive(true);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollForceScript : MonoBehaviour {
    public GameObject Camera;
    public GameObject scoreText, gameOverPanel;
    private bool trampolineFinished = false, gameOver = false;

    private int ragdollInitialForceLevel = 50; // set from shared pref

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(250*ragdollInitialForceLevel, 50*ragdollInitialForceLevel));
	}
	
	// Update is called once per frame
	void Update () {
		if (trampolineFinished && !gameOver)
        {
            if (GetComponent<Rigidbody2D>().velocity.magnitude < 0.1)
            {
                Debug.Log("Game Over");
                gameOver = true;
                Camera.GetComponent<CameraMovementScript>().StopCameraMovement();
                scoreText.SetActive(false);
                gameOverPanel.SetActive(true);
            }
        }
	}

    public void TrampolineFinished()
    {
        trampolineFinished = true;
    }
}

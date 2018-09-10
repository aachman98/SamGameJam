using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovementScript : MonoBehaviour {

    public GameObject ragdoll;
    public Text scoreText, gameOverText;
    private bool followRagdoll = true;
    private int score;

    private int scoreMultiplier = 3; // set from shared pref

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (followRagdoll)
        {
            if (ragdoll.transform.position.x >= transform.position.x)
            {
                transform.position = new Vector3(ragdoll.transform.position.x, transform.position.y, transform.position.z);
                score += scoreMultiplier;
                scoreText.text = score.ToString();
                gameOverText.text = score.ToString();
                Debug.Log("Score: " + score);
            }
        }
	}

    public void StopCameraMovement()
    {
        followRagdoll = false;
    }
}

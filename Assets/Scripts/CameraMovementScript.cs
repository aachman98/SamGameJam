using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour {

    public GameObject ragdoll;
    private bool followRagdoll = true;
    private int score;

    private int scoreMultiplier = 1; // set from shared pref

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
                Debug.Log("Score: " + score);
            }
        }
	}

    public void StopCameraMovement()
    {
        followRagdoll = false;
    }
}

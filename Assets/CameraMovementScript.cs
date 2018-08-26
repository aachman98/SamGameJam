using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour {

    public GameObject ragdoll;
    private bool followRagdoll = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (followRagdoll)
        {
            if (ragdoll.transform.position.x > 0)
                transform.position = new Vector3(ragdoll.transform.position.x, transform.position.y, transform.position.z);
        }
	}

    public void StopCameraMovement()
    {
        followRagdoll = false;
    }
}

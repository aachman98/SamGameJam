using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatformScript : MonoBehaviour {

    private float nextSpawningPoint = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= nextSpawningPoint)
        {
            Debug.Log("Spawn platform: " + nextSpawningPoint);
            nextSpawningPoint += 16;
        }
	}
}

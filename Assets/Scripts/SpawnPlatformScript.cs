using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatformScript : MonoBehaviour {

    public GameObject[] platforms;
    private int platformToRespawn = 0;
    private float nextSpawningPoint = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= nextSpawningPoint)
        {
            Debug.Log("Spawn platform");
            platforms[platformToRespawn].transform.position += new Vector3(48, 0, 0);
            nextSpawningPoint += 16;
            platformToRespawn = (platformToRespawn + 1) % 3;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollForceScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(200, 50));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineForceScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, 2000, 0));
    }
}

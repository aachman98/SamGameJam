using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollForceScript : MonoBehaviour {
    private bool trampolineFinished = false, gameOver = false;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(1000, 200));
	}
	
	// Update is called once per frame
	void Update () {
		if (trampolineFinished && !gameOver)
        {
            if (GetComponent<Rigidbody2D>().velocity.magnitude < 0.1)
            {
                Debug.Log("Game Over");
                gameOver = true;
            }
        }
	}

    public void TrampolineFinished()
    {
        trampolineFinished = true;
    }
}

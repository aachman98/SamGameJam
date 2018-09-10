using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapInputScript : MonoBehaviour {

    public GameObject trampoline, ragdoll;
    private int trampolineCount;

	// Use this for initialization
	void Start () {
        trampolineCount = 5; // set from shared pref
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            if (trampolineCount > 0)
                SpawnTrampoline(Input.mousePosition.x);
        }
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                if (trampolineCount > 0)
                    SpawnTrampoline(Input.touches[0].position.x);
            }
        }
	}

    void SpawnTrampoline(float xCoordinate)
    {
        Instantiate(trampoline).transform.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(xCoordinate, 0, 0)).x, -4.3f, 0);
        trampolineCount--;
        if (trampolineCount == 0)
            ragdoll.GetComponent<RagdollForceScript>().TrampolineFinished();
    }
}

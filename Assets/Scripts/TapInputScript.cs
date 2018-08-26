using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapInputScript : MonoBehaviour {

    public GameObject trampoline;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse position: " + Input.mousePosition);
            SpawnTrampoline(Input.mousePosition.x);
        }
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Debug.Log("Touch position: " + Input.touches[0].position);
                SpawnTrampoline(Input.touches[0].position.x);
            }
        }
	}

    void SpawnTrampoline(float xCoordinate)
    {
        Instantiate(trampoline).transform.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(xCoordinate, 0, 0)).x, -3.5f, 0);
    }
}

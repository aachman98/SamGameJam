using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapInputScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse position: " + Input.mousePosition);
        }
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Debug.Log("Touch position: " + Input.touches[0].position);
            }
        }
	}
}

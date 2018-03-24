using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowStone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(2) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.1f, 0f, 0f);
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.1f, 0f, 0f);
        }

        if (Input.GetMouseButtonDown(1) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0f, 0f, -0.1f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, 0f, 0.1f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowStone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //(0)左ボタン(1)右ボタン(2)中ボタン
        if (Input.GetMouseButtonDown(1) || Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(100, 0, 0);
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(-100,0,0);
        }

        if (Input.GetMouseButtonDown(2) || Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(0,0,-100);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 100);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    private float defaultPosition = 1;
    private float ShootPosition = 0; 

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(transform.position);
        if (Input.GetMouseButtonDown(0) == true)
        {
            transform.Translate(0, 0, this.ShootPosition);
            Debug.Log("マウスを押した。");
        }
        if (Input.GetMouseButtonDown(0) == false)
        {
            Debug.Log("マウスを押してない。");
            transform.Translate(0, 0, this.defaultPosition);
        }
	}
}

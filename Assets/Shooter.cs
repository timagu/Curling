using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    //シューターの初期位置
    private float defaultPosition = 1;
    //マウスをクリックして動く位置
    private float ShootPosition = 0; 

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //クリックした時
        if (Input.GetMouseButtonDown(0) == true)
        {
            transform.Translate(0, 0, this.ShootPosition);
        }
        //離した時
        if (Input.GetMouseButtonDown(0) == false)
        {
            transform.Translate(0, 0, this.defaultPosition);
        }
	}
}

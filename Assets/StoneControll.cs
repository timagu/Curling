using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneControll : MonoBehaviour {

    Rigidbody rigid;

	// Use this for initialization
	void Start () {
        //RigidbodyのComponentを取得
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //マウスの左ボタンを押した時
		if (Input.GetMouseButtonDown(0))
        {
            //ストーンを掴む。
            //OnMouseDrag();


        }
        //マウスのボタンをドラッグした時
        if (Input.GetMouseButton(0))
        {
            //投げる強さを選択する。
                //強さメーター表示
                //ボタンを離したら、強さが決まる。
        }
	}

    private void FixedUpdate()
    {
        //マウスのボタンを離した時
        if (Input.GetMouseButtonUp(0))
        {
            //-Z座標方向へ飛ぶ。
            GetMouseButtonUp();
        }
    }
    //マウスのボタンをドラッグした時の処理
    /*private void OnMouseDrag()
    {
        Vector3 objectPointInScreen = Camera.main.WorldToScreenPoint(this.transform.position);

        Vector3 mousePointInScreen = new Vector3(Input.mousePosition.x, 0,Input.mousePosition.z);

        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        this.transform.position = mousePointInWorld;
    }*/
    //マウスのボタンをドラッグした時の処理
    void GetMouseButton()
    {
        //投げる強さを調整できる。
    }
    //マウスのボタンを離した時の処理
    void GetMouseButtonUp()
    {
        //-Z座標方向へ飛ばす。         //力
        rigid.AddForce(Vector3.down * 500);
    }
}

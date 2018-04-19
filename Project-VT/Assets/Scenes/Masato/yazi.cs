using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yazi : MonoBehaviour {
    public GameObject YaziImg;
    static public bool flg = ScrollHelp.flg;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//        YaziImg.transform.position = new Vector3(-8, 0, 0);
        Debug.Log(flg + "切り替わり");
        flg = ScrollHelp.flg;
        if (!flg){
            YaziImg.transform.position = new Vector3(5, -10, 0);
            ScrollHelp.PushFlg = false;
        }else{
            YaziImg.transform.position = new Vector3(5, 0, 0);
            ScrollHelp.PushFlg = true;
        }
		
	}
}

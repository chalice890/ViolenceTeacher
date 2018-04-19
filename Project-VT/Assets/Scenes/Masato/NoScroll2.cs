using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoScroll2 : MonoBehaviour {
    public GameObject NoImg2;
    static public bool flg = ScrollHelp.flg;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(flg + "切り替わり");
        int MenuNo = ScrollHelp.MenuNo;
        if (MenuNo == 1)
        {
            NoImg2.transform.position = new Vector3(-0.1f, -0.45f, 0);
        }
        else
        {
            NoImg2.transform.position = new Vector3(-0.1f, 10, 0);
        }

    }
}

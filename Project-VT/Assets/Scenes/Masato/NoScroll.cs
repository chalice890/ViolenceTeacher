using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoScroll : MonoBehaviour {
    public GameObject NoImg;
    static public int flg = ScrollHelp.flg;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log(flg + "切り替わり");
        int MenuNo = ScrollHelp.MenuNo;
        if (MenuNo == 0)
        {
            NoImg.transform.position = new Vector3(-0.1f, -0.45f, 0);
        }
        else
        {
            NoImg.transform.position = new Vector3(-0.1f, 10, 0);
        }

    }
}

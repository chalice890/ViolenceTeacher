using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlemove : MonoBehaviour {

    public GameObject Titleimg;
    public GameObject Titleimg2;
    public float movex;
    static public int titleflg = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Titleimg.transform.position.x < -3 )
        {
            Titleimg.transform.position += new Vector3(movex, 0, 0);
        }
        else
        {
            titleflg = 1;
        }
        if (titleflg == 1){
            if (Titleimg2.transform.position.x > -3)
            {
                Titleimg2.transform.position -= new Vector3(movex, 0, 0);
            }
        }
    }
}

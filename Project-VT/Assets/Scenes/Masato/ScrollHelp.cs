using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollHelp : MonoBehaviour {

    public GameObject HelpImg;
    public float movex = 0.2f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if(Input.GetKeyDown.)
        if (HelpImg.transform.position.x < 0)
        {
            HelpImg.transform.position -= new Vector3(movex, 0, 0);
        }
    }
}

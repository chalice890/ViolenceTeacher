using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moziugoki : MonoBehaviour {


    public GameObject StaffImg;
    public float movey = 0.2f;

    // Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
            StaffImg.transform.position += new Vector3(0, movey, 0);
    }

}

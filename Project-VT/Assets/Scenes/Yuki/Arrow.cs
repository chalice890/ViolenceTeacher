using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public GameObject arrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        int Y;

       // if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow)) {
            Y = Title.MenuNo;
            arrow.transform.position = new Vector3(-6, -Y*1.2f+(-2), 0);
       // }

    }
}

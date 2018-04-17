using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensing : MonoBehaviour {

    public bool sensingflg = false;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        //当たり判定に触れた時
        if (col.gameObject.tag == "Enemy")
        {
            sensingflg = true;
            Debug.Log("StandBy...");
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {

        //当たり判定から離れた時
        sensingflg = false;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

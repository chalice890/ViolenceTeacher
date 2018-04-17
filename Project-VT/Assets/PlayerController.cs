using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 0.1f;
    public int flg = 0; 

    // Use this for initialization
    void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        flg = -1;
        Debug.Log("Block!!");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        flg = 1;
        Debug.Log("Block!!");
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed*flg, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed*flg, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed*flg,0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*flg, 0, 0);
        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public enum DIR
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    };

    public float speed = 0.1f;
    private float Stress;
    public float Attack = 10.0f;
    public int PlayerDir = (int)DIR.UP;
    public bool Upattackflg = false;
    public bool Downattackflg = false;
    public bool Leftattackflg = false;
    public bool Rightattackflg = false;

    // Use this for initialization
    void Start ()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Block!!");
        //当たり判定に触れた時
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        Debug.Log("Blockout!!");
        //当たり判定から離れた時
    }

    // Update is called once per frame
    void Update () {

        Stress = StressControl.stressState;


        if (Input.GetKey(KeyCode.UpArrow))
        {
            //上キーを押したときy軸をspeed分上に動かす
            transform.Translate(0, speed, 0);
            PlayerDir = (int)DIR.UP;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //下キーを押したときy軸をspeed分下に動かす
            transform.Translate(0, -speed, 0);
            PlayerDir = (int)DIR.DOWN;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左キーを押したときx軸をspeed分左に動かす
            transform.Translate(-speed,0, 0);
            PlayerDir = (int)DIR.LEFT;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //右キーを押したときx軸をspeed分右に動かす
            transform.Translate(speed, 0, 0);
            PlayerDir = (int)DIR.RIGHT;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Stress += Attack;
            StressControl.stressState = Stress;
            Debug.Log("LowAttack!!");
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            Stress += Attack * 2;
            StressControl.stressState = Stress;
            Debug.Log("NormalAttack!!");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Stress += Attack * 3;
            StressControl.stressState = Stress;
            Debug.Log("HardAttack!!");
        }

    }
}

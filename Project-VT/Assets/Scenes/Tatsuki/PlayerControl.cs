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

    public enum ATTACKPOWER
    {
        NONE,
        LOW,
        MID,
        HIG
    };

    public float speed = 0.1f;
    //private float Stress;
    static public int Attack = 0;
    public int PlayerDir = (int)DIR.UP;
    private bool watchflg;
    private GameObject GetCol;
    public  GameObject[] hands;
    private int flameflg = 0;
    
    // Use this for initialization
    void Start ()
    {
        hands = GameObject.FindGameObjectsWithTag("Playerhand");
        for(int i = 0; hands[i] != null; i++)
        {
            hands[i].SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Block!!");
        //当たり判定に触れた時
    }

    private void OnCollisionExit2D(Collision2D col)
    {

        Debug.Log("Blockout!!");
        //当たり判定から離れた時
    }

    // Update is called once per frame
    void Update () {

        //Stress = StressControl.stressState;


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

        if (flameflg != 0 && ++flameflg > 3 )
        {
            flameflg = 0;
            if (GetCol.activeSelf != false)
            {
                GetCol.SetActive(false);
                Debug.Log("NoneEnemy");
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (PlayerDir)
            {
                case (int)DIR.UP:
                    GetCol = gameObject.transform.Find("UpCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.DOWN:
                    GetCol = gameObject.transform.Find("DownCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.LEFT:
                    GetCol = gameObject.transform.Find("LeftCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.RIGHT:
                    GetCol = gameObject.transform.Find("RightCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;        
            }
            Attack = (int)ATTACKPOWER.LOW;
            Debug.Log("LowAttack!!");
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            switch (PlayerDir)
            {
                case (int)DIR.UP:
                    GetCol = gameObject.transform.Find("UpCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.DOWN:
                    GetCol = gameObject.transform.Find("DownCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.LEFT:
                    GetCol = gameObject.transform.Find("LeftCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.RIGHT:
                    GetCol = gameObject.transform.Find("RightCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
            }
            Attack = (int)ATTACKPOWER.MID;
            Debug.Log("NormalAttack!!");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            switch (PlayerDir)
            {
                case (int)DIR.UP:
                    GetCol = gameObject.transform.Find("UpCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.DOWN:
                    GetCol = gameObject.transform.Find("DownCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.LEFT:
                    GetCol = gameObject.transform.Find("LeftCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
                case (int)DIR.RIGHT:
                    GetCol = gameObject.transform.Find("RightCollision").gameObject;
                    GetCol.SetActive(true);
                    flameflg = 1;
                    break;
            }
            Attack = (int)ATTACKPOWER.HIG;
            Debug.Log("HardAttack!!");
        }
    }
    

}

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

    static public int Attack = (int)ATTACKPOWER.NONE;
    private bool watchflg;
    private bool Waitflg = false;
    public int PlayerDir = (int)DIR.UP;
    private int flame = 0;
    public float speed = 0.1f;
    private GameObject GetCol;
    public GameObject[] hands;
    public bool Attackflg = false;

    public AudioClip lowattackSE;
    public AudioClip middleattackSE;
    public AudioClip highattackSE;
    private AudioSource ASource;
    private Animator Anima; 

    // Use this for initialization
    void Start ()
    {
        hands = GameObject.FindGameObjectsWithTag("Playerhand");
        for(int i = 0; i < 2; i++)
        {
            hands[i].SetActive(false);
        }
        ASource = gameObject.GetComponent<AudioSource>();
        Anima = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //当たり判定に触れた時
        Debug.Log("Block!!");
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        //当たり判定から離れた時
        Debug.Log("Blockout!!");
    }

    // Update is called once per frame
    void Update () {

        //Stress = StressControl.stressState;

        Anima.SetBool("Wait", true);   

        if (Input.GetKey(KeyCode.UpArrow) && Attack == (int)ATTACKPOWER.NONE)
        {
            //上キーを押したときy軸をspeed分上に動かす
            transform.Translate(0, speed, 0);
            PlayerDir = (int)DIR.UP;
            Anima.SetBool("Wait", false);
            Anima.SetBool("Up", true);
            Anima.SetBool("Down", false);
            Anima.SetBool("Left", false);
            Anima.SetBool("Right", false);

        }

        if (Input.GetKey(KeyCode.DownArrow) && Attack == (int)ATTACKPOWER.NONE)
        {
            //下キーを押したときy軸をspeed分下に動かす
            transform.Translate(0, -speed, 0);
            PlayerDir = (int)DIR.DOWN;
            Anima.SetBool("Wait", false);
            Anima.SetBool("Up", false);
            Anima.SetBool("Down", true);
            Anima.SetBool("Left", false);
            Anima.SetBool("Right", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Attack == (int)ATTACKPOWER.NONE)
        {
            //左キーを押したときx軸をspeed分左に動かす
            transform.Translate(-speed,0, 0);
            PlayerDir = (int)DIR.LEFT;
            Anima.SetBool("Wait", false);
            Anima.SetBool("Up", false);
            Anima.SetBool("Down", false);
            Anima.SetBool("Left", true);
            Anima.SetBool("Right", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) && Attack == (int)ATTACKPOWER.NONE)
        {
            //右キーを押したときx軸をspeed分右に動かす
            transform.Translate(speed, 0, 0);
            PlayerDir = (int)DIR.RIGHT;
            Anima.SetBool("Wait", false);
            Anima.SetBool("Up", false);
            Anima.SetBool("Down", false);
            Anima.SetBool("Left", false);
            Anima.SetBool("Right", true);
        }

        if (Attack != (int)ATTACKPOWER.NONE && ++flame > 30 )
        {
            flame = 0;
            if (GetCol.activeSelf != false)
            {
                GetCol.SetActive(false);
                Debug.Log("NoneEnemy");
                Anima.SetBool("Wait", true);
            }
            Attack = (int)ATTACKPOWER.NONE;
            Anima.SetBool("Attack", false);
            Anima.SetBool("Low", false);
            Anima.SetBool("Middle", false);
            Anima.SetBool("High", false);
            Attackflg = false;

        }
        else if (flame == 15)
        {
            switch(Attack)
            {
                case (int)ATTACKPOWER.LOW:
                    ASource.clip = lowattackSE;
                    ASource.Play();
                    break;
                case (int)ATTACKPOWER.MID:
                    ASource.clip = middleattackSE;
                    ASource.Play();
                    break;
                case (int)ATTACKPOWER.HIG:
                    ASource.clip = highattackSE;
                    ASource.Play();
                    break;
            }
        }

        
        if(Attackflg == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                switch (PlayerDir)
                {
                    case (int)DIR.LEFT:
                        GetCol = gameObject.transform.Find("LeftCollision").gameObject;
                        GetCol.SetActive(true);
                        Attack = (int)ATTACKPOWER.LOW;
                        Debug.Log("LowAttack!!");
                        Anima.SetBool("Attack", true);
                        Anima.SetBool("Left", true);
                        Anima.SetBool("Low", true);
                        break;
                    case (int)DIR.RIGHT:
                        GetCol = gameObject.transform.Find("RightCollision").gameObject;
                        GetCol.SetActive(true);
                        Attack = (int)ATTACKPOWER.LOW;
                        Debug.Log("LowAttack!!");
                        Anima.SetBool("Attack", true);
                        Anima.SetBool("Right", true);
                        Anima.SetBool("Low", true);
                        break;
                }
                Attackflg = true;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                switch (PlayerDir)
                {
                    case (int)DIR.LEFT:
                        GetCol = gameObject.transform.Find("LeftCollision").gameObject;
                        GetCol.SetActive(true);
                        Attack = (int)ATTACKPOWER.MID;
                        Debug.Log("MiddleAttack!!");
                        Anima.SetBool("Attack", true);
                        Anima.SetBool("Left", true);
                        Anima.SetBool("Middle", true);
                        break;
                    case (int)DIR.RIGHT:
                        GetCol = gameObject.transform.Find("RightCollision").gameObject;
                        GetCol.SetActive(true);
                        Attack = (int)ATTACKPOWER.MID;
                        Debug.Log("MiddleAttack!!");
                        Anima.SetBool("Attack", true);
                        Anima.SetBool("Right", true);
                        Anima.SetBool("Middle", true);
                        break;
                }
                Attackflg = true;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                switch (PlayerDir)
                {
                    case (int)DIR.LEFT:
                        GetCol = gameObject.transform.Find("LeftCollision").gameObject;
                        GetCol.SetActive(true);
                        Attack = (int)ATTACKPOWER.HIG;
                        Debug.Log("HardAttack!!");
                        Anima.SetBool("Attack", true);
                        Anima.SetBool("Left", true);
                        Anima.SetBool("High", true);
                        break;
                    case (int)DIR.RIGHT:
                        GetCol = gameObject.transform.Find("RightCollision").gameObject;
                        GetCol.SetActive(true);
                        Attack = (int)ATTACKPOWER.HIG;
                        Debug.Log("HardAttack!!");
                        Anima.SetBool("Attack", true);
                        Anima.SetBool("Right", true);
                        Anima.SetBool("High", true);
                        break;
                }
                Attackflg = true;
            }
        }
    }
    

}

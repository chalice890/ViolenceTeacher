using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    public float sleepWaitTime;
    public float sleepLimitTime;
    public float subtractTime = 0.05f;
    public bool sflg = false;
    Animator anima;

	// Use this for initialization
	void Start ()
    {
        sleepWaitTime = Random.Range(15.0f, 30.0f);
        sleepLimitTime = (sleepWaitTime * -1);
        sflg = false;
        anima = transform.GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update ()
    {
        //叩かれて起こされたとき
        if (sleepWaitTime < 0 && sflg == false)
        {
            sflg = false;
            anima.SetBool("Sleepingflg", false);
            sleepWaitTime = Random.Range(15.0f, 30.0f);
            sleepLimitTime = (sleepWaitTime * -1);
            Debug.Log("WaaaaaaaakeUP!!");
        }

        //非睡眠時、睡眠時の内部タイマー
        if (sleepWaitTime >= sleepLimitTime)
        {
            sleepWaitTime -= subtractTime;
            if(sleepWaitTime <= 0 && sflg == false)
            {
                sflg = true;
                anima.SetBool("Sleepingflg",true);
                Debug.Log("Sleeeeeeep!!");
            }
        }

        //自分で起きた時
        if (sleepWaitTime < sleepLimitTime)
        {
            sflg = false;
            anima.SetBool("Sleepingflg", false);
            sleepWaitTime = Random.Range(15.0f, 30.0f);
            sleepLimitTime = (sleepWaitTime * -1);
            Debug.Log("WakeUP!!");
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    SpriteRenderer SRenderer;

    public float sleepWaitTime;
    public float sleepLimitTime;
    public float subtractTime = 0.05f;
    public bool sflg = false;
    public bool Famale = false;
    public bool Male = false;
    public Sprite WakeupImage;
    public Sprite SleepImage;


	// Use this for initialization
	void Start ()
    {
        sleepWaitTime = Random.Range(15.0f, 30.0f);
        sleepLimitTime = (sleepWaitTime * -1);
        sflg = false;
        SRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

	// Update is called once per frame
	void Update ()
    {
        //叩かれて起こされたとき
        if (sleepWaitTime < 0 && sflg == false)
        {
            sflg = false;
            SRenderer.sprite = WakeupImage;
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
                SRenderer.sprite = SleepImage;
                Debug.Log("Sleeeeeeep!!");
            }
        }

        //自分で起きた時
        if (sleepWaitTime < sleepLimitTime)
        {
            sflg = false;
            SRenderer.sprite = WakeupImage;
            sleepWaitTime = Random.Range(15.0f, 30.0f);
            sleepLimitTime = (sleepWaitTime * -1);
            Debug.Log("WakeUP!!");
        }


    }
}

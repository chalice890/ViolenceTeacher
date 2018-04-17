using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    public float sleepWaitTime;
    public float sleepLimitTime;
    public float subtractTime = 0.05f;
    static public bool sleepflg = false;

	// Use this for initialization
	void Start ()
    {
        sleepWaitTime = Random.Range(15.0f, 30.0f);
        sleepLimitTime = (sleepWaitTime * -1);
        sleepflg = false;
    }

	// Update is called once per frame
	void Update ()
    {
        if (sleepWaitTime >= sleepLimitTime)
        {
            sleepWaitTime -= subtractTime;
            if(sleepWaitTime <= 0 && sleepflg == false)
            {
                sleepflg = true;
                Debug.Log("Sleeeeeeep!!");
            }
        }

        if (sleepWaitTime < sleepLimitTime)
        {
            sleepflg = false;
            sleepWaitTime = Random.Range(7.0f, 15.0f);
            sleepLimitTime = (sleepWaitTime * -1);
            Debug.Log("WaaaaaaaakeUP!!");
        }

    }
}

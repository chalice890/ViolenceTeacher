using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LimitTimer : MonoBehaviour {

    public float counttime = 60;
    private GameObject[] go;
    private bool Gameoverflg;
    private bool Chackflg = false;

	// Update is called once per frame
	void Update ()
    {
        if(counttime > 0.0f)
        {
            counttime -= Time.deltaTime;
            GetComponent<Text>().text = counttime.ToString("F2");
        }
        else if(counttime <= 0.0f && !Chackflg)
        {
            go = GameObject.FindGameObjectsWithTag("Enemy");

            for(int i = 0; go[0] = null; i++)
            {
                if(go[0].GetComponent<EnemyControl>().sflg == true)
                {
                    Gameoverflg = true;
                    break;
                }
            }

            if(Gameoverflg == false)
            {
                GetComponent<Text>().text = "GameOver";
            }
            else
            {
                GetComponent<Text>().text = "GameClear";
            }
        }
    }
}

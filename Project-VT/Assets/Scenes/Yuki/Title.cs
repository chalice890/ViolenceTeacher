using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    static public int MenuNo = 0;

    // Use this for initialization 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MenuNo += 1;
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MenuNo -= 1;
        }

        if (MenuNo > 2) MenuNo = 2;
        if (MenuNo < 0) MenuNo = 0;
        
      //  Debug.Log(MenuNo);

        if (Input.GetKeyDown(KeyCode.Z))
            switch (MenuNo)
            {
                case 0:
                    SceneManager.LoadScene("GameMain");
                   // Debug.Log("メインに行くよー");
                    break;
                case 1:
                    SceneManager.LoadScene("GameHelp");
                   // Debug.Log("HELP");
                    break;
                case 2:
                    SceneManager.LoadScene("GameEnd");
                   // Debug.Log("END");
                    break;
            }
    }

    /* if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetButtonDown("Action1") || Input.GetButtonDown("Jump")) //マウス左クリック、スペースキー、Aボタン、ジャンプボタンを押した場合 
     { 
           SceneManager.LoadScene("some_sensei");//some_senseiシーンをロードする 
     } */

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    private AudioSource ASource;
    public AudioClip CursolSE;
    public AudioClip SelectSE;

    static public int MenuNo = 0;

    // Use this for initialization 
    void Start()
    {
        AudioSource[] AS = GetComponents<AudioSource>();
        ASource = AS[1];
    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (++MenuNo > 2)
            {
                MenuNo = 2;
            }
            ASource.clip = CursolSE;
            ASource.Play();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (--MenuNo < 0)
            {
                MenuNo = 0;
            }
            ASource.clip = CursolSE;
            ASource.Play();
        }


        //  Debug.Log(MenuNo);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (MenuNo)
            {
                case 0:
                    SceneManager.LoadScene("Tatsuki");
                    // Debug.Log("メインに行くよー");
                    break;
                case 1:
                    SceneManager.LoadScene("masato2");
                    // Debug.Log("HELP");
                    break;
                case 2:
                    SceneManager.LoadScene("Masato");
                    // Debug.Log("END");
                    break;
            }
            ASource.clip = SelectSE;
            ASource.Play();
        }
    }

    /* if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetButtonDown("Action1") || Input.GetButtonDown("Jump")) //マウス左クリック、スペースキー、Aボタン、ジャンプボタンを押した場合 
     { 
           SceneManager.LoadScene("some_sensei");//some_senseiシーンをロードする 
     } */

}

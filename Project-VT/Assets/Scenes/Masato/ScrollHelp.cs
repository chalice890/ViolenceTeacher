using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollHelp : MonoBehaviour {

    public GameObject HelpImg;
    public float movex = 0.2f;
    static public int MenuNo = 0;
    static public bool flg = true;
    static public bool PushFlg;

    // Use this for initialization
    void Start()
    {
        MenuNo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        chgScene();

        flg = true;
        if (flg)
        {
            if (PushFlg)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    MenuNo += 1;
                    if (MenuNo > 2) MenuNo = 2;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    MenuNo -= 1;
                    if (MenuNo < 0) MenuNo = 0;
                }
            }
        }

        if (MenuNo == 0)
        {
            if (HelpImg.transform.position.x < 13)
            {
                flg = false;
                HelpImg.transform.position += new Vector3(movex, 0, 0);
                Debug.Log("0");
            }
        }
        else if (MenuNo == 1)
        {
            if (HelpImg.transform.position.x > 0)
            {
                flg = false;
                HelpImg.transform.position -= new Vector3(movex, 0, 0);
                Debug.Log("1");
            }
            if (HelpImg.transform.position.x < -0.2f)
            {
                flg = false;
                HelpImg.transform.position += new Vector3(movex, 0, 0);
                Debug.Log("0");
            }
        }
        else if (MenuNo == 2)
        {
            if (HelpImg.transform.position.x > -13)
            {
                flg = false;
                HelpImg.transform.position -= new Vector3(movex, 0, 0);
                Debug.Log("2");
            }
            if (HelpImg.transform.position.x > -0.2f)
            {
                flg = false;
                HelpImg.transform.position += new Vector3(movex, 0, 0);
                Debug.Log("1");
            }
        }
        
    }

    void chgScene()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (MenuNo == 0) SceneManager.LoadScene("Yuki");
            if (MenuNo == 2) SceneManager.LoadScene("Tatsuki");
        }
    }
}

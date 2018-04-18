using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollHelp : MonoBehaviour {

    public GameObject HelpImg;
    public float movex = 0.2f;
    static public int MenuNo = 0;
    static public int flg = 0;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        flg = 0;
        if (flg == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow)){
                MenuNo += 1;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow)){
                MenuNo -= 1;
            }
        }

        if(MenuNo == 0){
            if (HelpImg.transform.position.x < 13) {
                flg = 1;
                HelpImg.transform.position += new Vector3(movex, 0, 0);
                Debug.Log("0");
            }
        }else if (MenuNo == 1){
            if (HelpImg.transform.position.x > 0){
                flg = 1;
                HelpImg.transform.position -= new Vector3(movex, 0, 0);
                Debug.Log("1");
            }
            if (HelpImg.transform.position.x < -0.2f){
                flg = 1;
                HelpImg.transform.position += new Vector3(movex, 0, 0);
                Debug.Log("0");
            }
        }else if(MenuNo == 2){
            if (HelpImg.transform.position.x > -13){
                flg = 1;
                HelpImg.transform.position -= new Vector3(movex, 0, 0);
                Debug.Log("2");
            }
            if (HelpImg.transform.position.x > -0.2f){
                flg = 1;
                HelpImg.transform.position += new Vector3(movex, 0, 0);
                Debug.Log("1");
            }
            //HelpImg.transform.position = new Vector3(-13, 0, 0);
        }else if (MenuNo < 0) { 
            //  SceneManager.LoadScene("GameTitle");
            Debug.Log("GameTitle来ました。");
        }else{
            //  SceneManager.LoadScene("GameMain");
            Debug.Log("GameMain来ました。");
        }
       
    }
}

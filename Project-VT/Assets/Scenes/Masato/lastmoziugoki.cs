using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastmoziugoki : MonoBehaviour {

    public GameObject StaffImg;
    public float movey = 0.2f;
    public float endTime = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (StaffImg.transform.position.y < 0)
        {
            StaffImg.transform.position += new Vector3(0, movey, 0);
        }

        endTime -= Time.deltaTime;

        if (endTime < 0)
        {
            Application.Quit();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitTimer : MonoBehaviour {

    public float counttime = 60;  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counttime -= Time.deltaTime;
        GetComponent<Text>().text = counttime.ToString("F2");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StressControl : MonoBehaviour {

    static public float stressState = 0f;
    public float subtract = 0.05f;

	//// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update ()
    {
        if (stressState < 100.0f)
        {
            if (stressState - subtract > 0.0f)
            {
                stressState -= subtract;
            }
            GetComponent<Text>().text = stressState.ToString("F2");
        }
        else
        {
            GetComponent<Text>().text = "GameOver";
        }

    }
}

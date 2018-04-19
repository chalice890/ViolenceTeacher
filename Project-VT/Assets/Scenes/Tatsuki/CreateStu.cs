using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStu : MonoBehaviour {

    public GameObject StudentF,StudentM;
    private int Cx = -6;
    private int Cy = 3;
    public bool flg = false;
    private GameObject go;

	// Use this for initialization
	void Awake ()
    {

        for(int i = 1; i <= 20; i++)
        {
            if(i % 2 == 0)
            {
                go = Instantiate(StudentM) as GameObject;
                go.transform.GetComponent<EnemyControl>().Male = true;
            }
            else
            {
                go = Instantiate(StudentF) as GameObject;
                go.transform.GetComponent<EnemyControl>().Famale = true;
            }

            go.transform.position = new Vector3(Cx, Cy, 0);
            Cy -= 2;
            if (i % 4 == 0)
            {
                Cy = 3;
                Cx += 3;

            }

        }

    }
}

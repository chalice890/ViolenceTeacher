using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStu : MonoBehaviour {

    public GameObject Student;
    private int Cx = -6;
    private int Cy = 3;
    public bool flg = false;

	// Use this for initialization
	void Start ()
    {

        for(int i = 1; i <= 20; i++)
        {
            GameObject go = Instantiate(Student) as GameObject;
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

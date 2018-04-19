using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensing : MonoBehaviour {

    private float Stress;
    public float Attack = 0.05f;
    public float BadAttack = 0.1f;
    private bool Hitflg;
    private bool moveflg = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Stress = StressControl.stressState;

        //当たり判定に生徒が触れた時
        if (col.gameObject.tag == "Enemy")
        {
            Hitflg = col.GetComponent<EnemyControl>().sflg;
            //寝ているか寝ていないか
            if (Hitflg != false)
            {
                Stress += Attack*(PlayerControl.Attack);
                StressControl.stressState = Stress;
                col.GetComponent<EnemyControl>().sflg = false;
                Debug.Log("Hit");
            }
            else
            {
                Stress += BadAttack*(PlayerControl.Attack);
                StressControl.stressState = Stress;
                Debug.Log("Miss");

            }

        }
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        
        //当たり判定を仕事させるためのちょっとした移動
        if(moveflg == false)
        {
            transform.Translate(0.001f, 0, 0);
            moveflg = !moveflg;

        }
        else
        {
            transform.Translate(-0.001f, 0, 0);
            moveflg = !moveflg;
        }

    }
}

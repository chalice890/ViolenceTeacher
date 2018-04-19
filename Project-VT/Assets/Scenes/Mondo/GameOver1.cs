using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour
{

    private AudioSource ASource;
    public AudioClip CursolSE;
    public AudioClip SelectSE;
    // Use this for initialization
    void Start()
    {
        AudioSource[] AS = GetComponents<AudioSource>();
        ASource = AS[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Yuki");
            ASource.clip = CursolSE;
            ASource.Play();
        }
    }
}

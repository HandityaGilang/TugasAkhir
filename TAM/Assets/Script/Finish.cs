using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource suarafinish;

    private bool Levelselesai = false;

    private void Start()
    {
        suarafinish = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !Levelselesai)
        {
            suarafinish.Play();
            Levelselesai = true;
            Invoke("LevelComplete", 2f);
        }
    }

    private void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

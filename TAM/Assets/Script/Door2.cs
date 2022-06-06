using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    public GameObject connectedDoor;
    private GameObject Player;

    private AudioSource suarafinish;

    private bool Levelselesai = false;

    public KeyFollow2 key;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        suarafinish = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Key" && !Levelselesai)
        {
            if(Input.GetAxisRaw("Vertical") == 1)
            {
                suarafinish.Play();
                Levelselesai = true;
                Invoke("LevelComplete", 2f);
            }
        }
    }

    private void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

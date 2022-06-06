using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Animator animasi;

    [SerializeField] private AudioSource suaramati;
    // Start is called before the first frame update
    private void Start()
    {
        animasi = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    //jika nyentuh trap
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("trap"))
        {
            Die();
        }
    }

    
    private void Die()
    {
        suaramati.Play();
        rigid.bodyType = RigidbodyType2D.Static;
        animasi.SetTrigger("Dead");
        
    }
     
     //kalo mati ngulang
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}   


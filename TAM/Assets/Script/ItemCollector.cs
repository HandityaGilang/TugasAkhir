using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int hitungitem = 0;

    [SerializeField]private Text textItem;
    [SerializeField]private AudioSource suaraitem;
   private void OnTriggerEnter2D(Collider2D collision)
   {
       //jika player nyentuh item
       if(collision.gameObject.CompareTag("Orange"))
       {
           suaraitem.Play();
           Destroy(collision.gameObject);
           hitungitem = hitungitem + 1;
           textItem.text = "Score:"+hitungitem;
       }
   }
}

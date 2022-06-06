using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFollow2 : MonoBehaviour
{
    private SpringJoint2D spring;
    // Start is called before the first frame update
    void Start()
    {
        spring = GetComponent<SpringJoint2D>();
        spring.enabled = false;
        GameObject backpack = GameObject.FindWithTag("Backpack");
        spring.connectedBody = backpack.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.gameObject.tag == "Player")
        {
            spring.enabled = true;
        }
    }
}

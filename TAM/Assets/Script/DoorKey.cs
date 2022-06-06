using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{

    private PlayerMovement player;
    
    public SpriteRenderer SR;
    public Sprite doorOpen;
    public bool Open, waitingToOpen;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitingToOpen)
        {
            if(Vector3.Distance(player.followingkey.transform.position, transform.position) < 0.1)
            {
                waitingToOpen = false;
                Open = true;
                SR.sprite = doorOpen;
                player.followingkey.gameObject.SetActive(false);
                player.followingkey = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            if(player.followingkey !=null)
            {
                player.followingkey.followtarget = transform;
                waitingToOpen = true;
            }
        }
    }
}

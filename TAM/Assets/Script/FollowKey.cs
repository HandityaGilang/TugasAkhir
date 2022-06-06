using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowKey : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isFollow;
    public float followspeed;
    public Transform followtarget;

    public PlayerMovement player;

    
    // Start is called before the first frame update
    void Start()
    {
         player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollow)
        {
            transform.position = Vector3.Lerp(transform.position, followtarget.position, followspeed = Time.deltaTime);
        }
    }
     //kalo ke trigger kunci
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!isFollow)
            {
                

                followtarget = player.KeyFollowingPoint;

                isFollow = true;

            }
        }
    }
}

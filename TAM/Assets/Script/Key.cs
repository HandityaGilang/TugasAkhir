using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool isFollow;
    public float followspeed;
    public Transform followtarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollow)
        {
            transform.position = Vector3.Lerp(transform.position, followtarget.position, followspeed = Time.deltaTime);
        }
    }
}

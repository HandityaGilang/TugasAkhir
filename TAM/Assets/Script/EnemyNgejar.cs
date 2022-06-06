using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNgejar : MonoBehaviour
{   
    public GameObject player;

    private Transform playerpos;

    private Vector2 currentpos;

    public float distance;

    public float speedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        playerpos = player.GetComponent<Transform>();
        currentpos = GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerpos.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerpos.position, speedEnemy*Time.deltaTime);
        }
        else
        {
            if(Vector2.Distance(transform.position, currentpos) <=0)
            {

            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentpos,speedEnemy*Time.deltaTime);
            }
        }
    }
}

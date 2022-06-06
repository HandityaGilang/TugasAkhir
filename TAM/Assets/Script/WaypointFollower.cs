using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{  [SerializeField]private GameObject[] waypoint;
private int waypointindex = 0;
[SerializeField] private float speed = 2;
    //waypoint
    private void Update()
    {
        if(Vector2.Distance(waypoint[waypointindex].transform.position, transform.position) < .1)
        {
            waypointindex = waypointindex +1;
            if(waypointindex >= waypoint.Length)
            {
                waypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoint[waypointindex].transform.position, Time.deltaTime*speed); 
    }
}

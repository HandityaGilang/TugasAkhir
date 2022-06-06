using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    [SerializeField] private float movespeed;
    public Transform target;

    private Rigidbody2D rb;

    private Vector3 Targetpos;

    [SerializeField] private float JumpHeight;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Targetpos = new Vector3(target.position.x, rb.position.y, 0);
        rb.position = Vector2.MoveTowards(transform.position, Targetpos, movespeed* Time.deltaTime);
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0, JumpHeight));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Jump();
    }
}

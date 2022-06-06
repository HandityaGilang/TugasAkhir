using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidb;
    private Animator animasi;
    private BoxCollider2D coll;
    private SpriteRenderer karakter;
    private float direcX = 0f;

    public FollowKey followingkey;

    public Transform KeyFollowingPoint;

    private enum MovementState {idle,run,lompat,jatuh };

    [SerializeField] private AudioSource SuaraLoncat;

    [SerializeField]private float moveSpeed = 7f;
    [SerializeField]private float jumpForce = 14f;
    [SerializeField]private LayerMask JumpableGround;


    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        rigidb =  GetComponent<Rigidbody2D>();
        karakter = GetComponent<SpriteRenderer>();
        animasi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        direcX = Input.GetAxisRaw("Horizontal");
        rigidb.velocity = new Vector2(direcX * moveSpeed, rigidb.velocity.y);
        
        //ketika spasi
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            //ambilrigidBody2d
            SuaraLoncat.Play();
           rigidb.velocity = new Vector2(rigidb.velocity.x, jumpForce);
           
        }
        Updateanimasi();
    }
    private void Updateanimasi()
    {
        MovementState lokasisekarang;
         //ketika jalan
        if(direcX >0)
        {
            lokasisekarang = MovementState.run;
            karakter.flipX = false;
        }
        else if(direcX < 0)
        {
            lokasisekarang = MovementState.run;
            karakter.flipX = true;
        }
        else
        {
            lokasisekarang = MovementState.idle;
        }
         //ketika lompat
        if(rigidb.velocity.y > .1f)
        {
            lokasisekarang = MovementState.lompat;
        }
        else if(rigidb.velocity.y < -.1f)
        {
            lokasisekarang = MovementState.jatuh;
        }

        animasi.SetInteger("state",(int)lokasisekarang);
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f,JumpableGround);
    }
}

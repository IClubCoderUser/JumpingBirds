using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Player2D : MonoBehaviour

{
    private Rigidbody2D _physics;
    private bool _isGround;
    public float jump = 6
        ;
    private SpriteRenderer flip;
    public float speed = 1;


    // Start is called before the                                                                                                                                                                              
    void Start()
    {
        _physics = GetComponent<Rigidbody2D>();
        flip = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            flip.flipX = false;
        }
        if (horizontal < 0)
            flip.flipX = true;

            if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _physics.AddForce(Vector2.up*jump, ForceMode2D.Impulse);


        }
        var vector = new Vector2(x: horizontal * speed, y: _physics.velocity.y);
        _physics.velocity = vector;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    { _isGround = false; }




}


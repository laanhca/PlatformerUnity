using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
   private InputHandler _inputHandler;
   
   public bool isGround;
   [SerializeField] private LayerMask Ground;
    void Start()
    {
        this.currentState = new IdleState();
        this.currentState.onEnter(this);
        this.jumpForce = 50000;
        _inputHandler = new InputHandler(this);
    }

    private void FixedUpdate()
    {
        // if (this.rb2d.velocity.y > 0)
        // {
        //     this.coll.isTrigger = true;
        // }
        // else
        // {
        //     this.coll.isTrigger = false;
        // }
    }

    void Update()
    {

        checkGrounded();
        _inputHandler.Update(Time.deltaTime);
        currentState.onUpdate(Time.deltaTime);
        setFlipX();

    }

    private bool checkGrounded()
    {
        if (coll.IsTouchingLayers(Ground))
        {
            return isGround = true;
        }
        return isGround = false;
    }

    private void setFlipX()
    {
        if (this.isFacing)
        {
            this.spriteRenderer.flipX = true;
        }
        else
        {
            this.spriteRenderer.flipX = false;
        }
    }

}

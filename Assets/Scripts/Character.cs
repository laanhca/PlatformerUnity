using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected float healthPoint;
    protected float currentHealthPoint;
    public float jumpForce;
    public Rigidbody2D rb2d;
    public SpriteRenderer spriteRenderer;
    protected Animator _animator;
    public Collider2D coll;
    private float _speed;
    public bool isFacing = false;
    [SerializeField] protected BaseState currentState;
    void Awake()
    {
        this._animator = GetComponent<Animator>();
        this.rb2d = GetComponent<Rigidbody2D>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.coll = GetComponent<Collider2D>();
        this._speed = 3;
    }
    public void SetState(int newState)
    {
        BaseState mBaseState = this.currentState.setSate(newState);
        if (mBaseState != null)
        {
            this.currentState.onExit();
            this.currentState = mBaseState;
            this.currentState.onEnter(this);
        }
        
    }

    public void SetSpeed(float newSpeed)
    {
        this._speed = newSpeed;
    }
    public float GetSpeed()
    {
        return this._speed ;
    }

    public Animator getAnimator()
    {
        return _animator;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputHandler 
{
    private Player player;
    
    
    public InputHandler(Player player)
    {
        this.player = player;
    }
    private float pressHorizontal=0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update(float dt)
    {
        pressHorizontal = Input.GetAxis("Horizontal");
        UpdateMove();
        UpdateJump();
        
    }

    private void UpdateJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && player.isGround)
        {
            player.rb2d.AddForce(Vector2.up*player.jumpForce);
            player.SetState(Global.JUMP_STATE);
        }
        if (Input.GetKeyDown(KeyCode.Q) && player.isGround)
        {
            
            player.SetState(Global.ATTACK_STATE);
        }
    }

    public void UpdateMove()
    {
       
       
           
        if (pressHorizontal == 0 && player.isGround)
        {
            player.SetState(Global.IDLE_STATE);
           
        }
           
        
        if (pressHorizontal > 0 )
        {
            player.SetState(Global.RUN_STATE);
            player.isFacing = false;
            
        }
        
        
        if (pressHorizontal < 0 )
        {
            player.isFacing = true;
            player.SetState(Global.RUN_STATE);
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseState
{
    public override BaseState setSate(int newSate)
    {
        switch (newSate)
        {
            case Global.RUN_STATE:
                return new RunState();
            case  Global.IDLE_STATE:
                return new IdleState();
            case Global.JUMP_STATE:
                return new JumpState();
            default: return null;
        }
    }

    public override void onEnter(Character character)
    {
        
    }

    public override void onUpdate(float dt)
    {
        
    }

    public override void onExit()
    {
        
    }
}

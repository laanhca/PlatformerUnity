using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public override BaseState setSate(int newSate)
    {
        switch (newSate)
        {
            case Global.RUN_STATE:
                return new RunState();
            case Global.JUMP_STATE:
                return new JumpState();
            case Global.ATTACK_STATE:
                return new AttackState();
            default:
                return null;
        }
    }

    public override void onEnter(Character character)
    {
        character.getAnimator().SetInteger("state",Global.IDLE_STATE);
    }

    public override void onUpdate(float dt)
    {
        
    }

    public override void onExit()
    {
        
    }
}

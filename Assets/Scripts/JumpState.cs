using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : BaseState
{
    public override BaseState setSate(int newSate)
    {
        switch (newSate)
        {
            case Global.IDLE_STATE:
                return new IdleState();
            case  Global.RUN_STATE:
                return new RunState();
            case  Global.ATTACK_STATE:
                return new AttackState();
            default: return null;
        }
    }

    public override void onEnter(Character character)
    {
        character.getAnimator().SetInteger("state",Global.JUMP_STATE);
    }

    public override void onUpdate(float dt)
    {
        
    }

    public override void onExit()
    {
        
    }
}

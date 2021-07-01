using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class RunState : BaseState
{
    private Character _character;
    public override BaseState setSate(int newSate)
    {
        switch (newSate)
        {
            case Global.IDLE_STATE:
                return new IdleState();
            case Global.JUMP_STATE:
                return new JumpState();
            case Global.ATTACK_STATE:
                return new AttackState();
            default: return null;
        }
    }

    public override void onEnter(Character character)
    {
        this._character = character;
        character.getAnimator().SetInteger("state",Global.RUN_STATE);
    }

    public override void onUpdate(float dt)
    {
        if (this._character.isFacing)
        {
            _character.transform.position = new Vector3(_character.transform.position.x - _character.GetSpeed() * Time.deltaTime,
                           _character.transform.position.y, _character.transform.position.z);
        }
        else
        {
            _character.transform.position = new Vector3(_character.transform.position.x + _character.GetSpeed() * Time.deltaTime,
                _character.transform.position.y, _character.transform.position.z);
        }
    }

    public override void onExit()
    {
        
    }
}

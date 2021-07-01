using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public abstract BaseState setSate(int newSate);
    public abstract void onEnter(Character character);
    public abstract void onUpdate(float dt);
    public abstract void onExit();


}

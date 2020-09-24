using UnityEngine;
using System.Collections;

public class AttackingState : FSMState
{
    public override void Init()
    {
        StateID = FSMStateID.Attacking;
    }

    private float atkTime;
    public override void ActionState(FSMBase fsm)
    {
        base.ActionState(fsm);

        if(atkTime <= Time.time)
        {
            fsm.skillSystem.UseRandomSkill();

            atkTime = Time.time + fsm.chStatus.attackInterval;
        }

        
    }
}

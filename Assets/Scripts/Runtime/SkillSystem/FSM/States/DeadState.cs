using UnityEngine;
using System.Collections;

public class DeadState : FSMState
{
    public override void Init()
    {
        StateID = FSMStateID.Dead;
    }

    public override void EnterState(FSMBase fsm)
    {
        base.EnterState(fsm);

        //禁用状态机
        fsm.enabled = false;
    }
}

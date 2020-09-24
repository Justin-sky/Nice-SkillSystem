using UnityEngine;
using System.Collections;

public class IdleState : FSMState
{
    public override void Init()
    {
        StateID = FSMStateID.Idle;
    }

    public override void EnterState(FSMBase fsm)
    {
        base.EnterState(fsm);

        fsm.anim.SetBool("idle", true);
    }

    public override void ExitState(FSMBase fsm)
    {
        base.ExitState(fsm);

        fsm.anim.SetBool("idle", false);
    }
}

using UnityEngine;
using System.Collections;

//追逐状态
public class PursuitState : FSMState
{
    public override void Init()
    {
        StateID = FSMStateID.Pursuit;
    }

    public override void ActionState(FSMBase fsm)
    {
        base.ActionState(fsm);

        fsm.MoveToTarget(fsm.targetTF.position, fsm.chStatus.attackDistance, fsm.runSpeed);
    }

    public override void EnterState(FSMBase fsm)
    {
        base.EnterState(fsm);
        fsm.anim.SetBool("run", true);
    }

    public override void ExitState(FSMBase fsm)
    {
        base.ExitState(fsm);
        fsm.anim.SetBool("run", false);
    }
}

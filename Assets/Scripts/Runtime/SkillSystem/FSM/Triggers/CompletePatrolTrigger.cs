using UnityEngine;
using System.Collections;

public class CompletePatrolTrigger : FSMTrigger
{
    public override bool HandleTrigger(FSMBase fsm)
    {
        return fsm.isPatrolComplete;
    }

    public override void Init()
    {
        TriggerID = FSMTriggerID.CompletePatrol;

    }
}

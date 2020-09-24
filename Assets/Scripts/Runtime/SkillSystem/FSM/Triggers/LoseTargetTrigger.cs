using UnityEngine;
using System.Collections;

public class LoseTargetTrigger : FSMTrigger
{
    public override bool HandleTrigger(FSMBase fsm)
    {
        return fsm.targetTF == null;
    }

    public override void Init()
    {
        TriggerID = FSMTriggerID.LoseTarget;
    }
}

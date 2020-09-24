using UnityEngine;
using System.Collections;

//发现目标
public class SawTargetTrigger : FSMTrigger
{
    public override bool HandleTrigger(FSMBase fsm)
    {
        return fsm.targetTF != null;
    }

    public override void Init()
    {
        TriggerID = FSMTriggerID.SawTarget;
    }
}

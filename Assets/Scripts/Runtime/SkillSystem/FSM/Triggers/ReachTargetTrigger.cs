using UnityEngine;
using System.Collections;

//目标进入攻击范围
public class ReachTargetTrigger : FSMTrigger
{
    public override bool HandleTrigger(FSMBase fsm)
    {
        return Vector3.Distance(fsm.transform.position, fsm.targetTF.position) <= fsm.chStatus.attackDistance;
    }

    public override void Init()
    {
        TriggerID = FSMTriggerID.ReachTarget;
    }
}

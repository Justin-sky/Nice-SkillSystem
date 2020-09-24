using UnityEngine;
using System.Collections;

//打死目标
public class KilledTargetTrigger : FSMTrigger
{
    public override bool HandleTrigger(FSMBase fsm)
    {
        return fsm.targetTF.GetComponent<CharacterStatus>().HP <= 0;
    }

    public override void Init()
    {
        TriggerID = FSMTriggerID.KilledTarget;
    }
}

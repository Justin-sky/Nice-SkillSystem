using UnityEngine;
using System.Collections;

public abstract class FSMTrigger 
{
    public FSMTriggerID TriggerID { get; set; }

    public FSMTrigger(){
        Init();
    }

    public abstract void Init();

    public abstract bool HandleTrigger(FSMBase fsm);
}

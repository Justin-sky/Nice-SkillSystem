using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public abstract class FSMState 
{
    public FSMStateID StateID { get; set; }
    private Dictionary<FSMTriggerID, FSMStateID> map;

    private List<FSMTrigger> Triggers;

    public abstract void Init();
    public FSMState()
    {
        map = new Dictionary<FSMTriggerID, FSMStateID>();
        Triggers = new List<FSMTrigger>();
        Init();
    }

    //状态机调用
    public void AddMap(FSMTriggerID triggerID, FSMStateID stateID)
    {
        map.Add(triggerID, stateID);

        Type type = Type.GetType(triggerID + "Trigger");
        FSMTrigger trigger =  Activator.CreateInstance(type) as FSMTrigger;
        Triggers.Add(trigger);
    }

    //检测当前状态条件
    public void Reason(FSMBase fsm)
    {
        for(int i=0; i < Triggers.Count; i++)
        {
            if (Triggers[i].HandleTrigger(fsm))
            {
                FSMStateID stateID = map[Triggers[i].TriggerID];
                fsm.ChangeActiveState(stateID);

                return;
            }
        }
    }

    public virtual void EnterState(FSMBase fsm) { }
    public virtual void ActionState(FSMBase fsm) { }
    public virtual void ExitState(FSMBase fsm) { }
}

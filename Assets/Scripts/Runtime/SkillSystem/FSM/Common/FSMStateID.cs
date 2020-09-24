using UnityEngine;
using System.Collections;

public enum FSMStateID 
{
    None,
    Default,
    Dead,
    Idle,
    Pursuit,//追逐
    Attacking,
    Patrolling //巡逻
}

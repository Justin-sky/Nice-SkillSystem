using UnityEngine;
using System.Collections;

public enum FSMTriggerID
{

    NoHealth,
    SawTarget,//发现目标
    ReachTarget, //到达目标
    KilledTarget, //目标被击昏
    WithoutAttackRange, //超出攻击范围
    LoseTarget, //丢失目标
    CompletePatrol //完成巡逻
}

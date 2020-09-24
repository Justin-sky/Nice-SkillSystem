using UnityEngine;
using System.Collections;
using System;

public class PatrollingState : FSMState
{
    public override void Init()
    {
        StateID = FSMStateID.Patrolling;
    }

    public override void EnterState(FSMBase fsm)
    {
        base.EnterState(fsm);

        fsm.isPatrolComplete = false;

        //播放走路动画
        fsm.anim.SetBool("walk", true);
    }

    public override void ExitState(FSMBase fsm)
    {
        base.ExitState(fsm);

        fsm.anim.SetBool("walk", false);
    }
    public override void ActionState(FSMBase fsm)
    {
        base.ActionState(fsm);

        //巡逻模式： 单次  循环  往还
        switch (fsm.patrolMode)
        {
            case PatrolMode.Once:
                OncePatrolling(fsm);
                break;
            case PatrolMode.Loop:
                LoopPatrolling(fsm);
                break;
            case PatrolMode.PingPong:
                PingPongPatrolling(fsm);
                break;
        }
    }

    private int index;
    private void OncePatrolling(FSMBase fsm)
    {
         //a - b - c
        if (Vector3.Distance(fsm.transform.position, fsm.wayPoints[index].position) < 0.1)
        {
            if (index == fsm.wayPoints.Length - 1)
            {
                fsm.isPatrolComplete = true;
                return;
            }

            index++;
        }
        fsm.MoveToTarget(fsm.wayPoints[index].position, 0, fsm.walkSpeed);
    }
    private void LoopPatrolling(FSMBase fsm)
    {
        // a - b - c - a - b - c -...
        if (Vector3.Distance(fsm.transform.position, fsm.wayPoints[index].position) < 0.1)
        {
            if (index == fsm.wayPoints.Length - 1)
            {
                index = (index +1) % fsm.wayPoints.Length;
            }

        }

        fsm.MoveToTarget(fsm.wayPoints[index].position, 0, fsm.walkSpeed);

    }
    private void PingPongPatrolling(FSMBase fsm)
    {
        //a b c b a b c b
        if (Vector3.Distance(fsm.transform.position, fsm.wayPoints[index].position) < 0.1)
        {
            if (index == fsm.wayPoints.Length - 1)
            {
                Array.Reverse(fsm.wayPoints);
                index++;
            }
            index = (index + 1) % fsm.wayPoints.Length;
        }

        fsm.MoveToTarget(fsm.wayPoints[index].position, 0, fsm.walkSpeed);
    }
}

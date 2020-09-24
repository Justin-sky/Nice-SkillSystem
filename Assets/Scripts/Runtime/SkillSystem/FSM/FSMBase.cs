using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
/**
*  当前状态                  条件            目标状态
*  ————————————————————————————
*   待机                生命为0                死亡
*                        发现目标              追逐
* ----------------------------------------------------------
*    死亡
* ------------------------------------------------------------
*    追逐               生命为0                 死亡
*                       目标进入攻击范围        攻击
*                       丢失目标                转为默认状态
*  -----------------------------------------------------------
*  攻击                 生命为0                  死亡
*                       玩家离开攻击范围         追逐
*                       打死目标                 转为默认状态
* -------------------------------------------------------------
*    巡逻                生命为0                  死亡
*                        发现目标                  追逐
*                        完成巡逻                 待机
*/
public class FSMBase:MonoBehaviour
{
    private List<FSMState> states;
    public FSMStateID defaultStateID;

    private FSMState currentState;
    private FSMState defaultState;

    [HideInInspector]
    public Animator anim;
    [HideInInspector]
    public CharacterStatus chStatus;

    [HideInInspector]
    public Transform targetTF;
    public string[] targetTags = { "Player"};
    public float sightDistance = 10;

    public float runSpeed = 2;
    public float walkSpeed = 1;

    private NavMeshAgent navAgent;

    [HideInInspector]
    public CharacterSkillSystem skillSystem;


    public Transform[] wayPoints;
    public PatrolMode patrolMode; //巡逻模式
    [HideInInspector]
    public bool isPatrolComplete; //是否巡逻完成

    private void Start()
    {
        ConfigFSM();
        InitDefaultState();
        InitComponent();
    }

    public void InitComponent()
    {
        anim = GetComponentInChildren<Animator>();
        chStatus = GetComponent<CharacterStatus>();
        navAgent = GetComponent<NavMeshAgent>();
        skillSystem = GetComponent<CharacterSkillSystem>();
    }

    private void SearchTarget()
    {
        SkillData data = new SkillData(){
            attackTargetTags=targetTags,
            attackDistance = sightDistance,
            attackAngle = 360,
            attackType = SkillAttackType.Single
        };
        Transform[] targetArr =  new SelectorAttackSelector().SelectTarget(data, transform);
        targetTF = targetArr.Length == 0 ? null : targetArr[0];
    }

    public void MoveToTarget(Vector3 position, float stopDistance, float moveSpeed)
    {
        navAgent.SetDestination(position);
        navAgent.stoppingDistance = stopDistance;
        navAgent.speed = moveSpeed;
    }

    //配置状态机
    private void ConfigFSM()
    {
        states = new List<FSMState>();

        IdleState idle = new IdleState();
        idle.AddMap(FSMTriggerID.NoHealth, FSMStateID.Dead);
        idle.AddMap(FSMTriggerID.SawTarget, FSMStateID.Pursuit);
        states.Add(idle);

        DeadState dead = new DeadState();
        states.Add(dead);


        PursuitState pursuit = new PursuitState();
        pursuit.AddMap(FSMTriggerID.NoHealth, FSMStateID.Dead);
        pursuit.AddMap(FSMTriggerID.ReachTarget, FSMStateID.Attacking);
        pursuit.AddMap(FSMTriggerID.LoseTarget, FSMStateID.Default);
        states.Add(pursuit);


        AttackingState attacking = new AttackingState();
        attacking.AddMap(FSMTriggerID.NoHealth, FSMStateID.Dead);
        attacking.AddMap(FSMTriggerID.WithoutAttackRange, FSMStateID.Pursuit);
        attacking.AddMap(FSMTriggerID.KilledTarget, FSMStateID.Default);
        states.Add(attacking);


        PatrollingState patrolling = new PatrollingState();
        patrolling.AddMap(FSMTriggerID.NoHealth, FSMStateID.Dead);
        patrolling.AddMap(FSMTriggerID.SawTarget, FSMStateID.Pursuit);
        patrolling.AddMap(FSMTriggerID.CompletePatrol, FSMStateID.Idle);
        states.Add(patrolling);
    }


    private void InitDefaultState()
    {
        defaultState = states.Find(s => s.StateID == defaultStateID);
        currentState = defaultState;

        currentState.EnterState(this);
    }

    public void Update()
    {
        currentState.Reason(this);

        currentState.ActionState(this);

        SearchTarget();
    }

    //切换状态
    public void ChangeActiveState(FSMStateID stateID)
    {

        currentState.ExitState(this);
        if(stateID == FSMStateID.Default)
        {
            currentState = defaultState;
        }
        else
        {
            currentState = states.Find(s => s.StateID == stateID);
        }
        currentState.EnterState(this);

    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SkillData : MonoBehaviour
{
    public int skillID;
    public string name;
    public string description;
    public int coolTime;
    public int coolRemain;
    public int costSP;
    public float attackDistance;
    public float attackAngle;
    public string[] attackTargetTags = { "Enemy"};
    [HideInInspector] public Transform[] attakcTargets;
    public string[] impactType = { "CostSP", "Damage" };
    public int nextBattlerId;
    public float atkRatio;
    public float durationTime;
    public float atkInterval;
    [HideInInspector] public GameObject owner;
    public string prefabName;
    [HideInInspector] public GameObject skillPrefab;
    public string animationName;
    public string hitFxName;
    [HideInInspector] public GameObject hitFxPrefab;
    public int level;
    public SkillAttackType attackType;
    public SelectorType selectorType;

}

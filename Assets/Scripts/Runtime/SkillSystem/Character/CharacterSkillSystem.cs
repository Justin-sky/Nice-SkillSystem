using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//封装技能系统
public class CharacterSkillSystem : MonoBehaviour
{

    private CharacterSkillManager skillManager;
    private SkillData skill;   //如果要同时放多个技能。。此处用队列
    private Animator anim;
    [HideInInspector]
    public Transform selectedTarget;


    private void Start()
    {
        skillManager = GetComponent<CharacterSkillManager>();
        anim = GetComponentInChildren<Animator>();
        //GetComponentInChildren<AnimationEventBehaviour>().attackHanlder += DeploySkill();
    }

    //生成技能
    private void DeploySkill()
    {
        skillManager.GenerateSkill(skill);
    }


    
    public void AttackUseSkill(int skillID, bool isBatter = false) {
        if(skill != null && isBatter)
        {
            skillID = skill.nextBattlerId;
        }
        
        //准备技能
        skill = skillManager.PrepareSkill(skillID);
        if (skill == null) return;

        //播放动画
        anim.SetBool(skill.animationName, true);

        //单攻： 朝向目标
        //Transform.LookAt()
        Transform targetTF = SelectTarget();
        transform.LookAt(targetTF);

        //1， 选中目标 间隔指定时间后取消选中
        // 2. 选中a目标 在自动取消前，又选中b目标，则需要手动将a取消

        SetSelectedActiveFx(false);
        selectedTarget = targetTF;
        SetSelectedActiveFx(true);

    }


    private Transform SelectTarget()
    {
       Transform[] target =  new SelectorAttackSelector().SelectTarget(skill, transform);
      
        return target.Length !=0 ? target[0] : null;
    }


    private void SetSelectedActiveFx(bool state)
    {
        if (selectedTarget == null) return;
        var selected = selectedTarget.GetComponent<CharacterSelected>();
        if (selected) selected.SetSelectedActive(true);
    }
    //NPC
    public void UseRandomSkill()
    {
        //var usableSkills = skillManager.skills.FindAll(s => skillManager.PrepareSkill(s.skillID) != null);
        //if (usableSkills.Length == 0) return;

        //int index = Random.Range(0, usableSkills.Length);

        //AttackUseSkill(usableSkills[index].skillID);
    }

}

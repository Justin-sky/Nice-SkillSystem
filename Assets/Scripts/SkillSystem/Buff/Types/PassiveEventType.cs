using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillSystem
{
    /// <summary>
    /// 被动技能触发事件
    /// 常见的有，当xxx的时候，执行yyy的逻辑。触发条件，是一块逻辑
    /// </summary>
    public enum PassiveEventType
    {
        [Descriptor("当角色出生")]
        OnCreate = 0,
        [Descriptor("当角色死亡")]
        OnDie = 1,
        [Descriptor("当命中敌人")]
        OnHit = 2,
        [Descriptor("当被敌人命中")]
        OnBeHit = 3,
        [Descriptor("触发时间间隔(秒或帧)")]
        OnTime = 4,
        [Descriptor("当替换出入场")]
        OnChangeIn = 5,
        [Descriptor("当替换出场")]
        OnChangeOut = 6,
        [Descriptor("当击杀一个敌人")]
        OnKillEnemy = 7,
        [Descriptor("当连击打断")]
        OnBreakCombo = 8,
        [Descriptor("当必杀结束")]
        OnBiShaSkillOver = 9,
        [Descriptor("当播放技能（需要在技能编辑器里发送）")]
        OnPlaySkill = 10

    }

}


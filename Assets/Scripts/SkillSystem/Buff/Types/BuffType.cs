using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    ///  执行具体逻辑
    ///  就是当xxx时，执行yyy，这里，我整体抽象yyy为buffer，
    ///  分为持续性buffer和瞬时的buffer
    /// </summary>
    public enum BuffType
    {
        [Descriptor("数值buff")]
        SetValue = 0,
        [Descriptor("状态buff")]
        SetState = 1,
        [Descriptor("驱散状态(瞬时)")]
        ClearState = 2,
        [Descriptor("免疫状态buff")]
        ImuneState = 3,
        [Descriptor("改变值（瞬时或持续）")]
        ChangeValue = 4,
        [Descriptor("驱散数值buff(瞬时)")]
        ClearSetValue = 5,
        [Descriptor("免疫数值buff")]
        ImmuneSetValue = 6,
        [Descriptor("击退（瞬时）")]
        JiTui = 7,
        [Descriptor("减少debuff的时间（瞬时）")]
        DelDebuffTime = 8,
        [Descriptor("免疫伤害")]
        ImmuneDamage = 9,
        [Descriptor("切换命令组（瞬时）")]
        ChangeCmdGroup  = 10,
        [Descriptor("创建npc(瞬时)时")]
        CreateNpc = 11,
        [Descriptor("攻击类型转换")]
        DamageTypeWraper = 12,
        [Descriptor("改变按键cd(瞬时)")]
        ChangeCmdId = 13,
        [Descriptor("改变被动技能cd（瞬时）")]
        ChangePassiveSkillCd = 14,
        [Descriptor("嘲讽（瞬时）")]
        ChaoFeng = 15,
        [Descriptor("标记")]
        Flag = 16,
        [Descriptor("吸引（瞬时）")]
        Pull =  17
    }
}

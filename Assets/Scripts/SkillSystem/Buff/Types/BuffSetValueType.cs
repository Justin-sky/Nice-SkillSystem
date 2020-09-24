using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 数值类buff的数值类型
    /// 例如给玩家增加攻击，防御，暴击率等等。
    /// </summary>
    public enum BuffSetValueType
    {
        [Descriptor("攻防/攻击")]
        Atk = 0,
        [Descriptor("攻防/防御")]
        Def = 1,
        [Descriptor("最大HP")]
        MacHP = 2,
        [Descriptor("伤害类型/加成")]
        DamageAdd = 3,
        [Descriptor("伤害类型/减免")]
        DamageDel = 4,
        [Descriptor("暴击/暴击率")]
        CritRate = 5,
        [Descriptor("暴击伤害加成")]
        CritDamageAdd = 6,
        [Descriptor("格档率")]
        ParryRate = 7,
        [Descriptor("暴击/韧性率")]
        ToughnessRate = 8,
        [Descriptor("命中/命中率")]
        HitRate = 9,
        [Descriptor("命中/闪避率")]
        DodgeRate = 10,
        [Descriptor("固定伤害/加成")]
        FixedDamage = 11,
        [Descriptor("固定伤害/减免")]
        FixedAvoidDamage = 12,
        [Descriptor("移动速度")]
        MoveSpeed = 13,
        [Descriptor("SP 恢复系数")]
        SpAddFactor = 15,
        [Descriptor("HP 恢复系数")]
        HpAddFactor = 16,
        [Descriptor("对护盾的伤害系数")]
        ShieldDamageFactor = 17,
        [Descriptor("反弹伤害")]
        ReboundDamage = 18
    }
}

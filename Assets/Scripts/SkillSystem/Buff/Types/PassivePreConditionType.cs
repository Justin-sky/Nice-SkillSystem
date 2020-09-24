using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 被动技能触发前置条件
    /// 例如，当xxx时，有20%概率执行yyy逻辑
    /// 当触发，并达成一定条件的时候，才执行yyy。
    /// </summary>
    public enum PassivePreConditionType
    {
        [Descriptor("触发时间间隔（秒或帧）")]
        TimeDuration = 1,
        [Descriptor("触发次数间隔")]
        CountDuration = 2,
        [Descriptor("触发次数限制")]
        CountLimit = 3,
        [Descriptor("随机数")]
        Random = 4,
        [Descriptor("自己是队长 ")]
        SelfIsLeader = 5,
        [Descriptor("拥有类型")]
        TeamHasType = 6,
        [Descriptor("队伍人数")]
        TeamMemberCount = 7,
        [Descriptor("角色处于技能编号")]
        CullSkillId = 8,
        [Descriptor("拥有角色表id")]
        TeamHasCharacterCfgId = 9,
        [Descriptor("关卡地形")]
        LevelType = 10,
        [Descriptor("当前伤害类型")]
        DamageType = 11,
        [Descriptor("角色战斗状态")]
        CharacterBattleState = 12,
        [Descriptor("当前角色招式类型")]
        CullSkillType = 13,
        [Descriptor("未受伤害持续时间")]
        NoneDamageDuration = 14,

        [Descriptor("未配置")]
        None = 99
    }
}

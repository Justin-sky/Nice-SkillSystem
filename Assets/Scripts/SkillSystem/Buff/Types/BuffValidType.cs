using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// buffer 的生效条件
    /// 例如，添加一个buff，持续10秒，过程中，当血量低于10%，提升暴击率50%。
    /// 这种一般是，一个持续性buff，需要某些条件下，才生效
    /// </summary>
    public enum BuffValidType
    {
        //个人数据
        [Descriptor("检查单个数值buff")]
        CheckSetValueBuff = 0,
        [Descriptor("检查状态buff")]
        CheckStateBuff = 1,
        [Descriptor("血量Hp百分比")]
        CheckHpPercent = 2,
        [Descriptor("连击数")]
        CheckComboCount =3,
        [Descriptor("盾数值")]
        ShieldValue = 4,

        [Descriptor("角色类型")]
        CheckCharacterType = 60,
        [Descriptor("当前技能类型（skill_info配置）")]
        CurrSkillType = 61,

        [Descriptor("角色登场状态")]
        CheckInBattle = 100,

        [Descriptor("战斗时长")]
        BattleTime = 200,

        [Descriptor("包含某个buff")]
        HasBuffId = 201,
        [Descriptor("SP 百分比")]
        CheckSpPercent = 202,
        [Descriptor("当前招式状态")]
        CurrSkillState = 203,
        [Descriptor("当前姿势状态")]
        CurrPosType = 204,
        [Descriptor("检查多个数值buff")]
        CheckSetValueBuffList = 205,
        [Descriptor("检查buff id的叠加数")]
        CheckBuffOverlayCount = 206
    }
}

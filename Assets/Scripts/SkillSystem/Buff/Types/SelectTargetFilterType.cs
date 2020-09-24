using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 对目标的过滤
    /// 例如，当xxx时，对半径内血量大于50%的敌人，执行yyy
    /// </summary>
    public enum SelectTargetFilterType
    {
        //个人数据
        [Descriptor("角色数值")]
        CharacterValue = 0,

        [Descriptor("检查状态")]
        CheckState = 50,
        [Descriptor("是否队长")]
        IsLeader = 55,
        [Descriptor("角色类型")]
        CheckCharacterType = 60,

        //战场环境
        [Descriptor("战斗时长")]
        BattleTime = 100,
        [Descriptor("敌人数量")]
        EnemyCount = 101,
        [Descriptor("角色登场状态")]
        CheckInBattle = 102,
        [Descriptor("判断是否是角色id")]
        CheckIsCharacterCfgId = 103
    }
}

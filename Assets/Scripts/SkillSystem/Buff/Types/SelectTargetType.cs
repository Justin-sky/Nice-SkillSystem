using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 目标选择
    /// 例如，当xxx时，对半径内敌人，执行yyy
    /// </summary>
    public enum SelectTargetType
    {
        [Descriptor("自己")]
        Self = 0,
        [Descriptor("队伍")]
        Team = 1,
        [Descriptor("当前目标敌人")]
        TargetEnemy = 2,
        [Descriptor("半径内敌人")]
        RadiusEnemy = 3,
        [Descriptor("随机敌人")]
        RandomEnemy = 4,
        [Descriptor("半径内友方")]
        RadiusGroup = 5

    }
}

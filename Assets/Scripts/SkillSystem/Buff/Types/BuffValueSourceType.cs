using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 数值来源
    /// 例如，增加当前攻击力10%的防御力。数值可能是需要根据条件计算出来的
    /// </summary>
    public enum BuffValueSourceType
    {
        [Descriptor("直接设置")]
        Set = 1,

        [Descriptor("--数值类型 * value")]
        Value_1 = 51,
        [Descriptor("--数值类型 * 星数")]
        Value_2 = 52,
        [Descriptor("--数值类型 * level")]
        Value_3 = 53,

        [Descriptor("角色每拥有 x% SP， 获得 x%的")]
        Special_1 = 100,
        [Descriptor("等级每提升x级获得x的")]
        Special_2 = 101,
        [Descriptor("生命值低于x%时，每减少x%生命值，提高x")]
        Special_3 = 102,
        [Descriptor("目标生命值上限x%时，最大不超过当前敌人生命上限的x%")]
        Special_4 = 103,
        [Descriptor("周围每死亡一个单位 ，提高x")]
        Special_5 = 104,
    }
}

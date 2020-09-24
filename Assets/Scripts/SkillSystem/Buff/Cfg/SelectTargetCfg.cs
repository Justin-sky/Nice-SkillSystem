using System.Collections.Generic;
using TrueSync;

namespace SkillSystem
{
    public class SelectTargetCfg: ICfgValueSource
    {
        [Descriptor("目标类型")]
        public SelectTargetType targetType;

        [Descriptor("半径")]
        public FP targetRadius;

        [Descriptor("过滤条件列表")]
        public List<SelectTargetFilterType> filters = new List<SelectTargetFilterType>();

    }
}
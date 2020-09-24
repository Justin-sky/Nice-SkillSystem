using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public enum SkillTriggerType
    {
        [Descriptor("帧范围")]
        FrameRange,
        [Descriptor("指令")]
        Command,
        [Descriptor("浮空状态")]
        YPosType,
        [Descriptor("是否在命中状态")]
        InAtkingState,
        [Descriptor("当前攻击框击中")]
        CurrAtkBoxHited,
        [Descriptor("碰墙")]
        HitWall,
        [Descriptor("移动指令反向")]
        MoveCmdDirChange,
        [Descriptor("当前有移动指令")]
        HasMoveCmd,
        [Descriptor("碰撞信息")]
        BoxColliderInfo
    }
}

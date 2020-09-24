using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 持续性buff
    /// </summary>
    public class BufferCfg_base_Duration : BuffCfg_base
    {

        [Descriptor("持续时间（秒）")]
        public uint duration = 10;

        [Descriptor("叠加类型")]
        public BufferOverlayType overlaytype = BufferOverlayType.NotOverlay_Refresh;

        [Descriptor("最大叠加次数")]
        public uint overlayCount;
    }


    public class BufferCfg_SetValue : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_SetState : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_ImmuneState : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_ImmuneSetValue : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_ChangeValue : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_ImmuneDamage : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_DamageTypeWraper : BufferCfg_base_Duration
    {

    }

    public class BufferCfg_Flag : BufferCfg_base_Duration
    {

    }

}

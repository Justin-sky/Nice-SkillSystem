using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public class BuffCfg_base :ICfgValueSource
    {
        public uint cfgId;

        [Descriptor("目标配置")]
        public SelectTargetCfg targetCfg = new SelectTargetCfg();
    }


    public class BufferCfg_ClearState : BuffCfg_base
    {

    }

    public class BufferCfg_ClearSetValue: BuffCfg_base
    {

    }

    public class BufferCfg_JiTui : BuffCfg_base
    {

    }

    public class BufferCfg_DelDebufTime: BuffCfg_base
    {

    }

    public class BufferCfg_ChangeCmdGroup: BuffCfg_base
    {

    }

    public class BufferCfg_CreateNpc : BuffCfg_base
    {

    }

    public class BufferCfg_ChangeCmdCd : BuffCfg_base
    {

    }

    public class BufferCfg_ChangePassiveSkillCd : BuffCfg_base
    {

    }

    public class BufferCfg_ChaoFeng : BuffCfg_base
    {

    }

    public class BufferCfg_Pull : BuffCfg_base
    {

    }
}

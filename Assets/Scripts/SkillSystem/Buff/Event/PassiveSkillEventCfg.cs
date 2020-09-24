using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public abstract class PassiveSkillEventCfg_base : ICfgValueSource
    {
        [Descriptor("前置条件列表")]
        public List<PassiveSkillEventCfg_base> preConditions = new List<PassiveSkillEventCfg_base>();

        [Descriptor("创建buffer id（表格）")]
        public List<uint> bufferIds = new List<uint>();

        [Descriptor("创建被动技能")]
        public List<AddPassiveSkillCfg> passiveSkillIds = new List<AddPassiveSkillCfg>();

        public void SetValues(/** ICfgValueSeter source **/)
        {

        }

    }


    public class PassiveSkillEventCfg_OnCreate : PassiveSkillEventCfg_base
    {

    }

    public class PassiveSkillEventCfg_OnDie : PassiveSkillEventCfg_base
    {

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueSync;

namespace SkillSystem
{
    public class PassiveSkillEventPreConditionCfg_base
    {
        public virtual PassivePreConditionType type => PassivePreConditionType.None;

        public FP value;

        public virtual void SetValues(/** ICfgValueSeter source **/)
        {

        }

        public override string ToString()
        {
            return "";
        }

        public virtual bool IsValid(/**  PassiveSkillEventCtrl eventCtrl, Character enemy **/)
        {
            //int randomValue = BattleRandomUtil.RandomValue();
            //if (randomValue >= value) return false;

            return true;
        }
    }

    public class PassiveSkillEventPreConditionCfg_CountDuration : PassiveSkillEventPreConditionCfg_base
    {
    }

    public class PassiveSkillEventPreConditionCfg_TimeDuration : PassiveSkillEventPreConditionCfg_base
    {

    }

    public class PassiveSkillEventPreConditionCfg_CountLimit : PassiveSkillEventPreConditionCfg_base
    {

    }

    public class PassiveSkillEventPreConditionCfg_Random : PassiveSkillEventPreConditionCfg_base
    {

        public override PassivePreConditionType type => PassivePreConditionType.Random;
   
        
    
    }

}

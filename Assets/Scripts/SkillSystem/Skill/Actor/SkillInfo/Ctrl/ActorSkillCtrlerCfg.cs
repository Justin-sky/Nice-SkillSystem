using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 各种技能处理，播放音效，特效，设置速度等等
    /// </summary>
    public class ActorSkillCtrlerCfg_Base
    {
        public virtual SkillCtrlType type => SkillCtrlType.Speed;


        public List<ActorSkillTriggerCfg_Base> triggerList = new List<ActorSkillTriggerCfg_Base>();
    
        public bool isTrigger(/*SkillTriggerCheckData data, BuffValidCfg_CheckCharacterType owner*/)
        {
            //for(int i=0; i<triggerList.Count; i++)
            //{
            //    if(triggerList[i].isTrigger(data,owner) == false)
            //    {
            //        return false;
            //    }
            //}
            return true;
        }
    
    }

    public class ActorSkillCtrlerCfg_PassiveSkillEvent : ActorSkillCtrlerCfg_Base
    {

    }

    public class ActorSkillCtrlerCfg_SpecialAtk : ActorSkillCtrlerCfg_Base
    {

    }

    public class ActorSkillCtrlerCfg_ChangeSkillGroup: ActorSkillCtrlerCfg_Base
    {

    }

}

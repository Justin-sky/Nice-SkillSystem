using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public abstract class ActorSkillTriggerCfg_Base
    {
        public virtual SkillTriggerType type => SkillTriggerType.FrameRange;

        public virtual string toDesc()
        {
            return null;
        }

        public virtual bool isTrigger(/*SkillTriggerCheckData data, BuffValidCfg_CheckCharacterType owner*/)
        {
            return true;
        }
    }

    public class ActorSkillTriggerCfg_FrameRange : ActorSkillTriggerCfg_Base
    {
        public override SkillTriggerType type => SkillTriggerType.FrameRange;

        [Descriptor("开始帧")]
        public uint startFrame;

        [Descriptor("结束帧")]
        public uint endFrame;

        public override string toDesc()
        {
            return $"帧范围：{startFrame}-{endFrame}";
        }

        public override bool isTrigger(/*SkillTriggerCheckData data, BuffValidCfg_CheckCharacterType owner*/)
        {
           // if (data.frame < startFrame || data.frame > endFrame) return false;


            return base.isTrigger();
        }
    }

    public class ActorSkillTriggerCfg_Command : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_YPosType : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_InAtkingState : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_CurrAtkBoxHited : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_HitWall : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_MoveCmdDirChange: ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_HasMoveCmd : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_BoxColliderInfo : ActorSkillTriggerCfg_Base
    {

    }

    public class ActorSkillTriggerCfg_ReleaseCmd : ActorSkillTriggerCfg_Base
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public class BuffValidCfg_base
    {
        public virtual BuffValidType type => BuffValidType.BattleTime;
    
        public virtual bool isValid()
        {
            return true;
        }
    }

    public class BuffValidCfg_CheckSetValueBuff : BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckStateBuffer : BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckComboCount : BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckCharacterType : BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckInBattle : BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckHpPercent: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_BattleTime : BuffValidCfg_base {
    
    }


    public class BuffValidCfg_CurrSkillType: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_ShieldValue: BuffValidCfg_base
    {


    }

    public class BuffValidCfg_HasBuffId: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckSpPercent: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CurrSkillState: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CurrPosType: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckSetValueBuffList: BuffValidCfg_base
    {

    }

    public class BuffValidCfg_CheckBuffOverlayCount: BuffValidCfg_base
    {

        public override BuffValidType type => BuffValidType.CheckBuffOverlayCount;

        [Descriptor("buffer ID")]
        public uint bufferId;

        public ValueCheckCfg valueCheck = new ValueCheckCfg();

        public override bool isValid(/** Character target**/)
        {
            //valueCheck.isTrue(target.Buffer.getBufferOverlayCount(bufferId),true)


            return base.isValid();
        }

    }
}

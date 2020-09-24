using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueSync;

namespace SkillSystem
{
    public abstract class BufferValueSourceCfg_Value_Select_Base : BuffValueSourceCfg_Base
    {
    
    }

    public class BufferValueSourceCfg_Value_1: BufferValueSourceCfg_Value_Select_Base
    {
        public override BuffValueSourceType type => BuffValueSourceType.Value_1;

        [Descriptor("数值系统")]
        public FP valueFactor;

        [Descriptor("最大值系数")]
        public FP maxFactor;

        public  FP toValue(/**Character caster, Character target **/)
        {
            //Character valueCha = valueTarget(caster, target);
            //if(valueCha == null)
            //{
            //    return FP.Zero;
            //}
            //target = valueCha.BattleData.tempData.enemy;
            //FP Value = valueCha.BattleData.getValueType(BufferValueSourceCfg_Value_1, target) * valueFactor;
            //FP max = valueCha.BattleData.getValueType(maxSource, target) * maxFactor;

            //return TSMath.Min(Value, max);

            return FP.Zero;
        }
    }

    public class BufferValueSourceCfg_Value_2 : BufferValueSourceCfg_Value_Select_Base
    {

    }

    public class BufferValueSourceCfg_Value_3 : BufferValueSourceCfg_Value_Select_Base
    {

    }
}

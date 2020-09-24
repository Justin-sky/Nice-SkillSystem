using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public abstract class BuffValueSourceCfg_Base
    {

        public virtual BuffValueSourceType type => BuffValueSourceType.Value_1;
    }

    public class BuffValueSourceCfg_Set : BuffValueSourceCfg_Base
    {

    }

    public class BuffValueSourceCfg_CurrHitDropHp : BuffValueSourceCfg_Base
    {

    }


}

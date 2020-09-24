using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 切换招式的数据。比如在帧范围（0~10内）触发了指令（Up），
    /// 切换到招式xx
    /// </summary>
    public class ChangeCtrl
    {
        public List<ActorSkillTriggerCfg_Base> triggers;
    }
}

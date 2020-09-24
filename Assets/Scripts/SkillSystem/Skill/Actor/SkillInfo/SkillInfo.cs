using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 招式信息。每个招式可以由一个或多个动作（ActInfo）组成，
    /// 并可以选择动作的帧范围，这样最大程度地复用美术动作，
    /// 并可以由策划自由发挥，组合出新的动画。
    /// </summary>
    public class SkillInfo
    {
        public List<BoxInfo> boxInfos;
        public List<ChangeCtrl> changeCtrls;
        public List<ActorSkillCtrlerCfg_Base> skillCtrls;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 角色数据的根，包含所有角色相关数据
    /// </summary>
    public class ActorCfg
    {
        public List<ActInfo> actInfos = new List<ActInfo>();

        public List<SkillInfo> skillInfos = new List<SkillInfo>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// 一个动作的信息，对应美术制作的一个动画（animation）
    /// </summary>
    public class ActInfo
    {
        public string aniName;
        public List<FrameInfo> frameInfos = new List<FrameInfo>();
    }
}

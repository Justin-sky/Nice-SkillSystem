using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SkillSystem
{
    /// <summary>
    /// 每一帧的信息，一般包含攻击，被击框的信息（position，scale），以及一些复杂逻辑使用的标记
    /// </summary>
    public class FrameInfo
    {
        public float scale;
        public Vector3 pos;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    /// <summary>
    /// buffer 的叠加类型
    /// 例如，火焰buff，可叠加xxx层
    /// </summary>
    public enum BufferOverlayType
    {
        [Descriptor("不可叠加，可刷新")]
        NotOverlay_Refresh,
        [Descriptor("可叠加，可刷新")]
        Overlay_Refresh,
        [Descriptor("不可叠加，不可刷新")]
        NotOverlay_NotRefresh,
        [Descriptor("可叠加，不可刷新")]
        Overlay_NotRefresh
    }
}

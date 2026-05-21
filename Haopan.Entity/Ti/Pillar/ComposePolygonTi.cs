using Haopan.Entity.Dian;
using Haopan.Entity.Mian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Ti.Pillar
{
    /// <summary>
    /// 组合多边形
    /// </summary>
    [Serializable]
    public class ComposePolygonTi : ThreeDModelBase
    {
        public ComposePolygonTi() : base(ThreeDModelType.ComposePolygonTi)
        {
        }

        /// <summary>
        /// 底部
        /// </summary>
        public ThreeComposePolygon BottomTDComposePolygon { get; set; } = new ThreeComposePolygon();

        /// <summary>
        /// 高
        /// </summary>
        public decimal Height { get; set; }
    }
}

using Haopan.Entity.Dian;
using Haopan.Entity.Mian;
using Haopan.Entity.Xian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Ti.Pillar
{
    /// <summary>
    /// 圆弧体
    /// </summary>
    [Serializable]
    public class ArcTi : ThreeDModelBase
    {
        public ArcTi() : base(ThreeDModelType.ArcTi)
        {
        }

        /// <summary>
        /// 底部
        /// </summary>
        public ThreeDArc BottomTDArc { get; set; } = new ThreeDArc();

        /// <summary>
        /// 高
        /// </summary>
        public decimal Height { get; set; }
    }
}

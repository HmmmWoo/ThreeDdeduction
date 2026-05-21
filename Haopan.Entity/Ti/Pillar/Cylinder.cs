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
    /// 圆柱
    /// </summary>
    [Serializable]
    public class Cylinder : ThreeDModelBase
    {
        public Cylinder() : base(ThreeDModelType.Cylinder)
        {
        }

        /// <summary>
        /// 底部圆
        /// </summary>
        public ThreeDCircle BottomTDCircle { get; set; } = new ThreeDCircle();

        /// <summary>
        /// 高
        /// </summary>
        public decimal Height { get; set; }
    }
}

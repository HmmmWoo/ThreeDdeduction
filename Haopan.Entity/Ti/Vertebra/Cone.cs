using Haopan.Entity.Dian;
using Haopan.Entity.Mian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Ti.Vertebra
{
    /// <summary>
    /// 圆锥
    /// </summary>
    [Serializable]
    public class Cone : ThreeDModelBase
    {
        public Cone() : base(ThreeDModelType.Cone)
        {
        }

        /// <summary>
        /// 底部圆
        /// </summary>
        public ThreeDCircle TDCircle { get; set; } = new ThreeDCircle();

        /// <summary>
        /// 顶点Z坐标
        /// </summary>
        public decimal TipZ { get; set; }
    }
}

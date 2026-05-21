using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Mian
{
    [Serializable]
    public class ThreeDCircle : ThreeDModelBase
    {
        public ThreeDCircle() : base(ThreeDModelType.ThreeDCircle)
        {
        }

        /// <summary>
        /// 圆心
        /// </summary>
        public ThreeDPoint CenterPoint { get; set; }
        /// <summary>
        /// 半径
        /// </summary>
        public decimal Radius { get; set; }
        /// <summary>
        /// 法向量，定义圆所在平面的朝向。默认(0,0,1)表示XY平面上的圆
        /// </summary>
        public ThreeDPoint NormalVector { get; set; } = new ThreeDPoint(0, 0, 1);
    }
}

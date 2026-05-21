using Haopan.Entity.Dian;
using Haopan.Entity.Xian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Xian
{
    [Serializable]
    public class ThreeDArc : ThreeDModelBase
    {
        public ThreeDArc() : base(ThreeDModelType.ThreeDArc)
        {
        }
        /// <summary>
        /// 是否是顺时针
        /// </summary>
        public bool IsClockwise { get; set; } = false;

        public ThreeDPoint CenterPoint { get; set; }
        public ThreeDPoint Middle { get; set; }
        /// <summary>
        /// 半径
        /// </summary>
        public decimal Radius { get; set; }
        /// <summary>
        /// 起始点
        /// </summary>
        public ThreeDPoint StartP { get; set; }
        /// <summary>
        /// 终点点
        /// </summary>
        public ThreeDPoint EndP { get; set; }


        /// <summary>
        /// 法向量，定义圆弧所在平面的朝向。默认(0,0,1)表示XY平面上的圆弧
        /// </summary>
        public ThreeDPoint NormalVector { get; set; } = new ThreeDPoint(0, 0, 1);

        /// <summary>
        /// 以水平轴正方向（即3点钟方向）为0°，逆时针方向为正，顺时针为负
        /// </summary>
        public decimal StartRadius { get; set; }
        /// <summary>
        /// 从startAngle开始的扫过角度，负值为逆时针绘制，正值为顺时针绘制
        /// </summary>
        public decimal SweepRadius { get; set; }
    }
}

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
    /// 棱柱
    /// </summary>
    [Serializable]
    public class Prism : ThreeDModelBase
    {
        public Prism() : base(ThreeDModelType.Prism)
        {
        }

        /// <summary>
        /// 底部点集合  描述当前点图形形状
        /// </summary>
        public ThreeDPolygon BottomTDPolygon { get; set; } = new ThreeDPolygon();

        /// <summary>
        /// 高
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// 倾斜角度
        /// 顺时针旋转 0-360
        /// </summary>
        public double Radian { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        public string Direction { get; set; }
        /// <summary>
        /// 是否开启扫描路径
        /// 拉升方向在2D中6点至12点方向点集合需要以顶坐标为开始
        /// </summary>
        public bool IsSweep { get; set; } = false;
        public ThreeDLine SweepPath { get; set; }
    }
}

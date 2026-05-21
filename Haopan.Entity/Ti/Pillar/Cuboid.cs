using Haopan.Entity.Dian;

using System;

namespace Haopan.Entity.Ti.Pillar
{
    /// <summary>
    /// 长方体
    /// </summary>
    [Serializable]
    public class Cuboid : ThreeDModelBase
    {
        /// <summary>
        /// 仅限不获取完整Cuboid数据时使用
        /// </summary>
        public Cuboid() : base(ThreeDModelType.Cuboid)
        {
        }

        public Cuboid(decimal x, decimal y, decimal z, decimal length, decimal width, decimal height) : base(ThreeDModelType.Cuboid)
        {
            X = x;
            Y = y;
            Z = z;
            Length = length;
            Width = width;
            Height = height;
            CenterPD = new Haopan.Entity.Dian.ThreeDPoint(x + length / 2M, y + width / 2M, z + height / 2M);
        }

        public Cuboid(ThreeDPoint centerPD, decimal length, decimal width, decimal height) : base(ThreeDModelType.Cuboid)
        {
            CenterPD = centerPD;
            X = centerPD.X - length / 2M;
            Y = centerPD.Y - width / 2M;
            Z = centerPD.Z - height / 2M;
            Length = length;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// 左下角的点X（如果CenterPD和Length已知，则自动计算）
        /// </summary>
        public decimal X { get; set; }
        /// <summary>
        /// 左下角的点Y（如果CenterPD和Width已知，则自动计算）
        /// </summary>
        public decimal Y { get; set; }
        /// <summary>
        /// 左下角的点Z（如果CenterPD和Height已知，则自动计算）
        /// </summary>
        public decimal Z { get; set; }

        /// <summary>
        /// 中心点
        /// </summary>
        public ThreeDPoint CenterPD { get; set; }
        /// <summary>
        /// 长
        /// </summary>
        public decimal Length { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public decimal Width { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// X方向角度
        /// </summary>
        public decimal AngleX { get; set; } = 0;
        /// <summary>
        /// Y方向角度
        /// </summary>
        public decimal AngleY { get; set; } = 0;
        /// <summary>
        /// Z方向角度
        /// </summary>
        public decimal AngleZ { get; set; } = 0;
    }
}

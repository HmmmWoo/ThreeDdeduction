using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Haopan.Entity.Mian
{
    /// <summary>
    /// 3D面
    /// </summary>
    [Serializable]
    public class ThreeDRectangle : ThreeDModelBase
    {
        private ThreeDRectangle() : base(ThreeDModelType.ThreeDRectangle) { }
        public ThreeDRectangle(List<ThreeDPoint> threeDPoints) : base(ThreeDModelType.ThreeDRectangle)
        {
            this.Lst_ThreeDPoint = threeDPoints;
        }
        public ThreeDRectangle(ThreeDPoint BasePoint, decimal Length, decimal Width, double Radian, List<ThreeDPoint> Lst_ThreeDPoint) : base(ThreeDModelType.ThreeDRectangle)
        {
            this._BasePoint = BasePoint;
            this._Length = Length;
            this._Width = Width;
            this._Radian_TopView = Radian;
            this.Lst_ThreeDPoint = Lst_ThreeDPoint;
        }

        private ThreeDPoint _BasePoint;
        /// <summary>
        /// 左下角的点X（如果这个图形是斜的，那么为最左边的点）
        /// </summary>
        public ThreeDPoint BasePoint { get { return _BasePoint; } set { _BasePoint = value; } }
        private decimal _Length;
        /// <summary>
        /// 长
        /// </summary>
        public decimal Length { get { return _Length; } set { _Length = value; } }
        private decimal _Width;
        /// <summary>
        /// 宽
        /// </summary>
        public decimal Width { get { return _Width; } set { _Width = value; } }

        private double _Radian_FrontView;
        /// <summary>
        /// 前视图
        /// </summary>
        public double Radian_FrontView { get { return _Radian_FrontView; } set { _Radian_FrontView = value; } }

        private double _Radian_TopView;
        /// <summary>
        /// 俯视图
        /// </summary>
        public double Radian_TopView { get { return _Radian_TopView; } set { _Radian_TopView = value; } }

        private double _Radian_LeftView;
        /// <summary>
        /// 左视图
        /// </summary>
        public double Radian_LeftView { get { return _Radian_LeftView; } set { _Radian_LeftView = value; } }

        public List<ThreeDPoint> Lst_ThreeDPoint { get; set; }
    }
}

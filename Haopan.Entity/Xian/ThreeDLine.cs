using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Haopan.Entity.Xian
{
    [Serializable]
    public class ThreeDLine : ThreeDModelBase
    {
        public ThreeDLine() : base(ThreeDModelType.ThreeDLine)
        {
        }

        public ThreeDLine(ThreeDPoint startPoint, ThreeDPoint endPoint) : base(ThreeDModelType.ThreeDLine)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
        public ThreeDPoint StartPoint { get; set; }
        public ThreeDPoint EndPoint { get; set; }

        public decimal Height { get; set; }

        // 获取方向向量
        public ThreeDPoint Direction => (EndPoint - StartPoint).Normalized();

        // 计算直线长度
        public decimal Length() => (decimal)(EndPoint - StartPoint).Length;

        // 获取直线的参数方程：P(t) = Start + t * Direction
        public ThreeDPoint GetPointAtParameter(decimal t) =>
            StartPoint + ((EndPoint - StartPoint).Normalized() * t * Length());
    }
}


using Haopan.Entity.Dian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Mian
{
    [Serializable]
    public class ThreeDTriangle : ThreeDModelBase
    {
        public ThreeDTriangle() : base(ThreeDModelType.ThreeDTriangle)
        {
        }

        public ThreeDTriangle(ThreeDPoint a, ThreeDPoint b, ThreeDPoint c) : this()
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// 顶点A
        /// </summary>
        public ThreeDPoint A { get; set; }
        /// <summary>
        /// 顶点B
        /// </summary>
        public ThreeDPoint B { get; set; }
        /// <summary>
        /// 顶点C
        /// </summary>
        public ThreeDPoint C { get; set; }
    }
}

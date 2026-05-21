using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Ti
{
    /// <summary>
    /// 球体
    /// </summary>
    [Serializable]
    public class Sphere : ThreeDModelBase
    {
        public Sphere() : base(ThreeDModelType.Sphere)
        {
        }
        /// <summary>
        /// 中心点
        /// </summary>
        public ThreeDPoint CenterPD { get; set; } = new ThreeDPoint();

        /// <summary>
        /// 半径
        /// </summary>
        public decimal Radius { get; set; }

    }
}

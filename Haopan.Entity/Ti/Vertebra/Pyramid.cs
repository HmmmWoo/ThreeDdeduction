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
    /// 棱锥
    /// </summary>
    [Serializable]
    public class Pyramid : ThreeDModelBase
    {
        public Pyramid() : base(ThreeDModelType.Pyramid)
        {
        }


        public ThreeDPolygon BottomTDPolygon { get; set; } = new ThreeDPolygon();

        public ThreeDPoint UpTDPoint { get; set; } = new ThreeDPoint();

    }
}

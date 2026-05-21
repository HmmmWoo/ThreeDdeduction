using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Mian
{
    [Serializable]
    public class ThreeDPolygon : ThreeDModelBase
    {
        public ThreeDPolygon() : base(ThreeDModelType.ThreeDPolygon)
        {

        }
        public ThreeDPolygon(List<ThreeDPoint> _Lst_ThreeDPoint) : this()
        {
            this.Lst_ThreeDPoint = _Lst_ThreeDPoint;
        }

        public List<ThreeDPoint> Lst_ThreeDPoint { get; set; } = new List<ThreeDPoint>();
    }
}

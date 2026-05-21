using Haopan.Entity.Dian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Xian
{
    [Serializable]
    public class ThreeDPolyLine : ThreeDModelBase
    {
        public ThreeDPolyLine() : base(ThreeDModelType.ThreeDPolyLine)
        {
        }

        public List<ThreeDPoint> Lst_ThreeDPoint { get; set; } = new List<ThreeDPoint>();

    }
}

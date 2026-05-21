using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Mian
{
    [Serializable]
    public class ThreeComposePolygon : ThreeDModelBase
    {
        public ThreeComposePolygon() : base(ThreeDModelType.ComposePolygon)
        {

        }
        public ThreeComposePolygon(List<ThreeDModelBase> _Lst_ThreeDBase) : this()
        {
            this.Lst_ThreeDBase = _Lst_ThreeDBase;
        }

        public List<ThreeDModelBase> Lst_ThreeDBase { get; set; } = new List<ThreeDModelBase>();
    }
}

using Haopan.Entity.Dian;
using Haopan.Entity.Mian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Ti.Platform
{
    /// <summary>
    /// 圆台
    /// </summary>
    [Serializable]
    public class RoundPlatform : ThreeDModelBase
    {
        public RoundPlatform() : base(ThreeDModelType.RoundPlatform)
        {

        }

        public ThreeDCircle BottomTDCircle { get; set; } = new ThreeDCircle();

        public ThreeDCircle UpTDCircle { get; set; } = new ThreeDCircle();

    }
}

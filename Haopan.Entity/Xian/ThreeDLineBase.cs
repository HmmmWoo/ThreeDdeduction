using Haopan.Entity.Dian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Haopan.Entity.Xian
{
    [Serializable]
    public class ThreeDLineBase : ThreeDModelBase
    {
        private ThreeDLineModelType _ThreeDLineModelTypeType;
        public ThreeDLineBase(ThreeDLineModelType threeDLineModelType) : base(ThreeDModelType.ThreeDLine)
        {
            _ThreeDLineModelTypeType = threeDLineModelType;
        }

        public ThreeDLineModelType ThreeDLineModelTypeType
        {
            get
            {
                return _ThreeDLineModelTypeType;
            }
        }

    }
}

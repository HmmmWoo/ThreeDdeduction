using Haopan.Entity.Dian;
using Haopan.Entity.Mian;
using Haopan.Entity.Ti;
using Haopan.Entity.Ti.Pillar;
using Haopan.Entity.Ti.Platform;
using Haopan.Entity.Ti.Vertebra;
using Haopan.Entity.Xian;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Haopan.Entity
{
    /// <summary>
    /// 所有3D模型基类
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(ThreeDPoint))]
    [KnownType(typeof(ThreeDPoint))]

    [XmlInclude(typeof(ThreeDLine))]
    [KnownType(typeof(ThreeDLine))]
    [XmlInclude(typeof(ThreeDPolyLine))]
    [KnownType(typeof(ThreeDPolyLine))]

    [XmlInclude(typeof(ThreeDCircle))]
    [KnownType(typeof(ThreeDCircle))]
    [XmlInclude(typeof(ThreeDPolygon))]
    [KnownType(typeof(ThreeDPolygon))]
    [XmlInclude(typeof(ThreeDRectangle))]
    [KnownType(typeof(ThreeDRectangle))]
    [XmlInclude(typeof(ThreeDTriangle))]
    [KnownType(typeof(ThreeDTriangle))]
    [XmlInclude(typeof(ThreeDArc))]
    [KnownType(typeof(ThreeDArc))]


    [XmlInclude(typeof(Cuboid))]
    [KnownType(typeof(Cuboid))]
    [XmlInclude(typeof(Cylinder))]
    [KnownType(typeof(Cylinder))]
    [XmlInclude(typeof(Prism))]
    [KnownType(typeof(Prism))]
    [XmlInclude(typeof(ArcTi))]
    [KnownType(typeof(ArcTi))]

    [XmlInclude(typeof(PrismaticTable))]
    [KnownType(typeof(PrismaticTable))]
    [XmlInclude(typeof(RoundPlatform))]
    [KnownType(typeof(RoundPlatform))]

    [XmlInclude(typeof(Cone))]
    [KnownType(typeof(Cone))]
    [XmlInclude(typeof(Pyramid))]
    [KnownType(typeof(Pyramid))]

    [XmlInclude(typeof(Sphere))]
    [KnownType(typeof(Sphere))]
    [XmlInclude(typeof(ThreeComposePolygon))]
    [KnownType(typeof(ThreeComposePolygon))]
    [XmlInclude(typeof(ComposePolygonTi))]
    [KnownType(typeof(ComposePolygonTi))]

    
    public  class ThreeDModelBase
    {
        private ThreeDModelType _KouJianViewBaseType;
        public ThreeDModelBase(ThreeDModelType ModelType)
        {
            _KouJianViewBaseType = ModelType;
        }
        public ThreeDModelBase()
        {
            
        }

        public ThreeDModelType KouJianViewBaseType
        {
            get
            {
                return _KouJianViewBaseType;
            }
        }

        /// <summary>
        /// 等级(暂定等级最高10级)
        /// 目前先用在桩承台上（等级高的不能被等级低的扣除）
        /// </summary>
        public int Grade { set; get; } = 0;
    }
}

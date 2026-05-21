using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity
{
    public enum ThreeDModelType
    {
        /// <summary>
        /// 3D点
        /// </summary>
        ThreeDPoint,

        /// <summary>
        /// 3D线
        /// </summary>
        ThreeDLine,
        /// <summary>
        /// 3D折线
        /// </summary>
        ThreeDPolyLine,

        /// <summary>
        /// 三角形
        /// </summary>
        ThreeDTriangle,
        /// <summary>
        /// 3D圆
        /// </summary>
        ThreeDCircle,
        /// <summary>
        /// 3D圆弧
        /// </summary>
        ThreeDArc,
        /// <summary>
        /// 组合多边形
        /// </summary>
        ComposePolygon,
        /// <summary>
        /// 3D长方形
        /// </summary>
        ThreeDRectangle,
        /// <summary>
        /// 3D多边形（首尾相连）
        /// </summary>
        ThreeDPolygon,

        /// <summary>
        /// 长方体
        /// </summary>
        Cuboid,
        /// <summary>
        /// 圆柱体
        /// </summary>
        Cylinder,
        /// <summary>
        /// 棱柱
        /// </summary>
        Prism,

        /// <summary>
        /// 圆台
        /// </summary>
        RoundPlatform,
        /// <summary>
        /// 棱台
        /// </summary>
        PrismaticTable,

        /// <summary>
        /// 圆锥
        /// </summary>
        Cone,
        /// <summary>
        /// 棱锥
        /// </summary>
        Pyramid,

        /// <summary>
        /// 球体
        /// </summary>
        Sphere,
        /// <summary>
        /// 圆弧体
        /// </summary>
        ArcTi,
        /// <summary>
        /// 组合多边形体
        /// </summary>
        ComposePolygonTi,
    }
}

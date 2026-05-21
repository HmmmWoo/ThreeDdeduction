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
    /// 棱台
    /// </summary>
    [Serializable]
    public class PrismaticTable : ThreeDModelBase
    {
        public PrismaticTable(params KeyValuePair<ThreeDPoint, ThreeDPoint>[] BottomPD_UpPD) : base(ThreeDModelType.PrismaticTable)
        {
            if (BottomPD_UpPD.Count() < 3)
                throw new ParamDefineException("当前棱台参数定义错误！");

            BottomPD_UpPD.ToList().ForEach(o =>
            {
                BottomTDPolygon.Lst_ThreeDPoint.Add(o.Key);
                UpTDPolygon.Lst_ThreeDPoint.Add(o.Value);
            });
        }
        public PrismaticTable() : base(ThreeDModelType.PrismaticTable)
        {
            
        }

        public ThreeDPolygon BottomTDPolygon { get; set; } = new ThreeDPolygon();

        public ThreeDPolygon UpTDPolygon { get; set; } = new ThreeDPolygon();
    }
}

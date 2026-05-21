using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity.Dian
{
    /// <summary>
    /// 3D点
    /// </summary>
    [Serializable]
    public class ThreeDPoint : ThreeDModelBase
    {
        public ThreeDPoint() : base(ThreeDModelType.ThreeDPoint)
        {

        }

        public ThreeDPoint(decimal _X, decimal _Y, decimal _Z) : this()
        {
            this.X = _X;
            this.Y = _Y;
            this.Z = _Z;
        }

        /// <summary>
        /// 3D点的X坐标，单位mm
        /// </summary>
        public decimal X { get; set; }

        /// <summary>
        /// 3D点的Y坐标，单位mm
        /// </summary>
        public decimal Y { get; set; }

        /// <summary>
        /// 3D点的Z坐标，单位mm
        /// </summary>
        public decimal Z { get; set; }

        public static bool operator ==(ThreeDPoint TPD1, ThreeDPoint TPD2)
        {
            if (object.ReferenceEquals(TPD1, null))
                return object.ReferenceEquals(TPD2, null);
            return TPD1.Equals(TPD2);
        }
        public static bool operator !=(ThreeDPoint TPD1, ThreeDPoint TPD2)
        {
            return !(TPD1 == TPD2);
        }

        public static ThreeDPoint operator -(ThreeDPoint a, ThreeDPoint b)
        {
            return new ThreeDPoint(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static ThreeDPoint operator +(ThreeDPoint a, ThreeDPoint b)
        {
            return new ThreeDPoint(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        public static ThreeDPoint operator *(ThreeDPoint a, decimal scalar)
        {
            return new ThreeDPoint(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }
        public static ThreeDPoint operator /(ThreeDPoint a, decimal scalar)
        {
            return new ThreeDPoint(a.X / scalar, a.Y / scalar, a.Z / scalar);
        }

        public override bool Equals(object obj)
        {
            return obj is ThreeDPoint point &&
                   KouJianViewBaseType == point.KouJianViewBaseType &&
                   X == point.X &&
                   Y == point.Y &&
                   Z == point.Z;
        }
        // 两点间距离
        public double DistanceTo(ThreeDPoint other)
        {
            return (this - other).Length;
        }
        // 点积
        public decimal Dot(ThreeDPoint other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        // 向量叉积
        public ThreeDPoint Cross(ThreeDPoint other) =>
            new ThreeDPoint(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X
            );

        // 检查向量是否为零
        public bool IsZero(decimal tolerance = 0.000001m) =>
            Math.Abs(X) <= tolerance && Math.Abs(Y) <= tolerance && Math.Abs(Z) <= tolerance;

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + X.GetHashCode();
                hash = hash * 31 + Y.GetHashCode();
                hash = hash * 31 + Z.GetHashCode();
                hash = hash * 31 + KouJianViewBaseType.GetHashCode();
                return hash;
            }
        }
        // 长度
        public double Length
        {
            get { return Math.Sqrt((double)(X * X + Y * Y + Z * Z)); }
        }
        // 单位向量
        public ThreeDPoint Normalized()
        {
            
            {
                double len = Length;
                if (len < double.Epsilon)
                    return this;
                return this / (decimal)len;
            }
        }
    }
}

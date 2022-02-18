using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    /// <summary>
    /// 三角形
    /// </summary>
    class Triangle:Surface
    {
        readonly public float side1;
        readonly public float side2;
        readonly public float side3;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="side1">辺１</param>
        /// <param name="side2">辺２</param>
        /// <param name="side3">辺３</param>
        public Triangle(float side1 = 0, float side2 = 0, float side3 = 0)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override float GetSurface()
        {
            float s = (side1 + side2 + side3) / 2;
            return MathF.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        public override float GetCircumference()
        {
            return side1 + side2 + side3;
        }
        public override void GetBounds(out float width, out float height)
        {
            width = side1;
            float surface = GetSurface();
            height = surface / (side1 / 2);
        }
    }
}

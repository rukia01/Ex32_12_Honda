using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    /// <summary>
    /// 円
    /// </summary>
    class Circle:Surface
    {
        readonly public float radius;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="radius">円の半径</param>
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return radius * radius * MathF.PI;
        }
        public override float GetCircumference()
        {
            return radius * 2 * MathF.PI;
        }
        public override void GetBounds(out float width, out float height)
        {
            width = radius * 2;
            height = radius * 2;
        }
    }
}

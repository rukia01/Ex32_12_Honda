using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    /// <summary>
    /// 四角形
    /// </summary>
    class Rectangle : Surface
    {
        readonly public float width;
        readonly public float height;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="width">横</param>
        /// <param name="height">縦</param>
        public Rectangle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public override float GetSurface()
        {
            return width * height;
        }
        public override float GetCircumference()
        {
            return (width + height) * 2;
        }
        public override void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
    }
}

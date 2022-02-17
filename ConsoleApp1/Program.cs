using System;
using AbstractSample;

namespace Ex32

{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            //Surface testSurface = new Surface();  エラーになる
            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(3);
            Triangle triangle = new Triangle(4, 5, 3);
            Surface[] surfaces = {rectAngle1,rightTriangle,circle,triangle };
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"surfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
                surfaces[i].GetBounds(out width, out height);
                Console.WriteLine($"surfacesは横{width}、縦{height}の大きさの四角形に収まる。");
            }
        }
    
    }
}

using System;

namespace Point2DTo3DTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 700;
            int y = 500;
            int pWidth = 800;
            int pHeight = 600;

            float npX = ((float)x / pWidth * 2) - 1;
            float npY = ((float)y / pHeight * 2) - 1;

            Console.WriteLine($"x : {x}");
            Console.WriteLine($"y : {y}");
            Console.WriteLine($"width : {pWidth}");
            Console.WriteLine($"height : {pHeight}");

            Console.WriteLine($"screeenCoordX : {npX}");
            Console.WriteLine($"screeenCoordY : {npY}");
        }
    }
}

using System;

namespace GraphicEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            IRenderer raster = new RasterRenderer();
            IRenderer vector = new VectorRenderer();

            Shape circleRaster = new Circle(raster);
            Shape squareVector = new Square(vector);
            Shape triangleRaster = new Triangle(raster);
            Shape triangleVector = new Triangle(vector);

            circleRaster.Draw();
            squareVector.Draw();
            triangleRaster.Draw();
            triangleVector.Draw();
        }
    }
}

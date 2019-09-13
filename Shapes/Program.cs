using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    


    class ShapeFactory : GeometricShape
    {
        public GeometricShape getShape(ShapeType type)
        {

        }

        void GeometricShape.Draw()
        {

        }
    }

    enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }

    interface GeometricShape
    {
        void Draw();
    }

    class Line : GeometricShape
    {
        void GeometricShape.Draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }

    class Circle : GeometricShape
    {
        void GeometricShape.Draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }

    class Rectangle : GeometricShape
    {
        void GeometricShape.Draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
}

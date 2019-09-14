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

            ShapeFactory shape = new ShapeFactory();

            shape.GetShape(ShapeType.LINE).Draw();
            shape.GetShape(ShapeType.CIRCLE).Draw();
            shape.GetShape(ShapeType.RECTANGLE).Draw();

            if(shape.GetShape(ShapeType.TRIANGLE) == null) {
                Console.WriteLine("\nInvalid shape.");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }
    }
    


    class ShapeFactory : GeometricShape
    {
        public GeometricShape GetShape(ShapeType type)
        {
            switch(type)
            {
                case ShapeType.LINE:
                    return new Line();

                case ShapeType.CIRCLE:
                    return new Circle();

                case ShapeType.RECTANGLE:
                    return new Rectangle();

                default:
                    return null;
            }
        }

        void GeometricShape.Draw() // this does nothing
        {
            return;
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

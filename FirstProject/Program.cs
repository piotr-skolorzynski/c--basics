using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // example of polymorphism
            Shape[] shapes = { new Circle(), new Rectangle(), new Triangle() };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}



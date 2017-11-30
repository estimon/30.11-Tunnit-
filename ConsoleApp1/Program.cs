using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new Shape();
            shape1.x = 10;
            shape1.y = 20;
            shape1.height = 30;
            shape1.with = 40;


            var circle1 = new Circle();
            circle1.x = 5;
            circle1.y = 10;
            circle1.height = 20;
            circle1.with = 80;

            var rectangle1 = new rectangle();
            rectangle1.x = 20;
            rectangle1.y = 20;
            rectangle1.height = 5;
            rectangle1.with = 6;

            var traingle1 = new traingle();
            traingle1.x = 3;
            traingle1.y = 2;
            traingle1.height = 4;
            traingle1.with = 5;

            var shapes = new List<Shape>();
            shapes.Add(shape1);
            shapes.Add(circle1);
            shapes.Add(rectangle1);
            shapes.Add(traingle1);

            foreach (var item in shapes)
            {
                Console.WriteLine("preforming task");
            }

            Console.ReadLine();

            
        }
    }
}

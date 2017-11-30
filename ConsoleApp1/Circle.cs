using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing circle");
            base.draw();
        }
    }
}

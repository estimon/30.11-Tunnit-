using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class traingle: Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing traingle");
            base.draw();
        }
    }
}

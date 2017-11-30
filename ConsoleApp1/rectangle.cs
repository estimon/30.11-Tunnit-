using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class rectangle: Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing rectangle");
            base.draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ruut : shapes
    {
        int side = 4;



        public Ruut(int n)
        {

        }

        public override int area()
        {
            return side * side;
        }
    }
}

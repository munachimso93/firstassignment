 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths cal = new Maths(12, 50);
            cal.add();
            cal.subtract();
            cal.division();
            cal.multiplication();


        }
    }
}

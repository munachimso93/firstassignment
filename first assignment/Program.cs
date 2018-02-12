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
            Maths cal = new Maths();
            cal.add(12, 7);
            cal.subtract(12, 3);
            cal.division(12, 3);
            cal.multiplication(12, 3);


        }
    }
}

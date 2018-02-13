using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    class Maths
   
    {
        private int param1;
        private int param2;
        public Maths(int param1, int param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }
        public void add()
        {
             int result = param1 + param2;

            Console.WriteLine("the addition of {0} and {1} is {2}", param1, param2, result);  
        }

        public void subtract( )
        {
            int result = param1 - param2;

            Console.WriteLine("the addition of {0} and {1} is {2}", param1, param2, result);
        }
        public void division( )
        {
            int result = param1 / param2;

            Console.WriteLine("the addition of {0} and {1} is {2}", param1, param2, result);
        }
        public void multiplication( )
        {
            int result = param1 * param2;

            Console.WriteLine("the addition of {0} and {1} is {2}", param1, param2, result);

        }
            
    }
}

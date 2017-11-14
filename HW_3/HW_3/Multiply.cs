using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Multiply
    {
        public void multiply(int a, int b)
        {
            int result = 0;

            while (a > 0)
            {
                if ((a & 1) > 0)
                {
                    result += b;
                }

                b <<= 1;
                a >>= 1;
            }

            Console.WriteLine("{0}", result);
        }
    }
}

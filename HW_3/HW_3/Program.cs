using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //StateOfDay check = new StateOfDay();
            //check.addLesson();
            //check.checkLesson();

            //Multiply multi = new Multiply();
            //multi.multiply(12, 55);

            CountZeroAndUnit czau = new CountZeroAndUnit(10);
            Console.WriteLine(czau.returnInfoAboutDigit()); 

            Console.Read();
        }
    }
}

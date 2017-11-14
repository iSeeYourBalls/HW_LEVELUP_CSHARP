using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class CountZeroAndUnit
    {
        private int digit = 0;
        private int countZero = 0;
        private int countUnit = 0;

        public CountZeroAndUnit(int digit)
        {
            this.digit = digit;
        }

        public string returnInfoAboutDigit()
        {
            //BitArray ba = new BitArray(digit); 

            for (int i = 0; i < 8; i++)
            {
                if ((digit >> i) % 2 == 1)
                {
                    countUnit++;
                }
                else
                {
                    countZero++;
                }
            }

            return String.Format("Количество нулей в числе = {0}, количество единиц в числе = {1}", countZero, countUnit); ;
        }
    }
}

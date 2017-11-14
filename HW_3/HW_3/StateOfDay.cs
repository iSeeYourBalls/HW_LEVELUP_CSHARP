using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class StateOfDay
    {
        private byte schedule = 0;
        private string temp = "";

        private byte[] arrMask = {
                                    01, // 00000001
                                    02, // 00000010
                                    04, // 00000100
                                    08, // 00001000
                                    16, // 00010000
                                    32, // 00100000
                                    64 //  01000000
                                 };

        private string[] week = {
                                    "Понедельник", 
                                    "Вторник",
                                    "Среда",
                                    "Четверг",
                                    "Пятница",
                                    "Суббота",
                                    "Воскресенье"
                                };

        public void addLesson()
        {
            Console.WriteLine("Отметьте в какие дни будут проходить уроки, ответ нужно дать 1 - будет урок, 0 - не будет.");

            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine("\nВ {0} есть урок?", week[i]);
                temp += Console.ReadKey().KeyChar;
            }

            schedule = Convert.ToByte(ReverseString(temp), 2);
            Console.WriteLine(schedule);
        }

        public void checkLesson()
        {
            for (int i = 0; i < week.Length; i++)
            {
                if ((schedule & arrMask[i]) > 0)
                {
                    Console.WriteLine("{0} есть урок!", week[i]);
                }
                else
                {
                    Console.WriteLine("{0} нет урока!", week[i]);
                }
            }
        }

        private string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

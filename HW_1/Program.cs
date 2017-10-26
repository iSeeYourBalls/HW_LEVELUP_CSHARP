using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первая часть ДЗ

            Console.WriteLine("Введите диапозон символов для визуализации. Введите первый : ");
            int from = (int)Console.ReadKey().KeyChar;
            Console.WriteLine("\nВведите второй :");
            int to = (int)Console.ReadKey().KeyChar;

            int countChar = 0;

            if (from < to)
            {
                Console.WriteLine("\nПервый введенный символ равен {0}, второй равен {1}\nДиапазон от первого ко второму :", from, to);

                for (int i = from; i <= to; i++)
                {
                    Console.WriteLine("Символ = {0}, значение символа {1}", Convert.ToChar(i), i);
                    countChar++;
                }

                Console.WriteLine("\nМеняем местами переменные");
                some();

                //Выводим символы таблицей
                charTable(countChar, from, to, 3);

            }
            else if (from == to)
            {
                Console.WriteLine("Символы равны.");
            }
            else
            {
                Console.WriteLine("\nПервый введенный символ равен {0}, второй равен {1}\nДиапазон от первого ко второму :", to, from);

                for (int i = to; i < from; i++)
                {
                    Console.WriteLine("Символ = {0}, значение символа {1}", Convert.ToChar(i), i);
                    countChar++;
                }

                Console.WriteLine("\nМеняем местами переменные");
                some();

                //Выводим символы таблицей
                charTable(countChar, to, from, 5);
            }

            Console.Read();

        }

        //Вторая часть ДЗ
        private static void charTable(int countChar, int from, int to, int countRows)
        {
            double countColumns = Math.Ceiling((double)countChar / countRows);

            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    Console.SetCursorPosition(j + 50, i + 6); // Что бы сбоку
                    Console.WriteLine("{0}", Convert.ToChar(from++));
                    if (from > to)
                        break;
                }

            }
        }

        //Третья
        private static void some()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            
            c = a;
            a = b;
            b = c + a;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a,b,c);
        }


    }
}

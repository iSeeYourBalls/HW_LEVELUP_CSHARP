using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            drawTable();
            addLesson();
            Console.ReadKey();
        }

        private static void drawTable(byte schedule = 0)
        {
            int x = 5;
            int y = 2;

            Console.SetCursorPosition(x, y);
            for (int i = 0; i <= 28; i++)
            {
                if (i % 4 == 0)
                {
                    x = Console.CursorLeft;
                    for (int j = 0; j < 4; j++)
                    {
                        Console.SetCursorPosition(x, y + j);
                        Console.WriteLine("|");
                        if (j == 1 && i < 28)
                        {
                            Console.SetCursorPosition(x+1, y + j);

                            daysOfWeek day;

                            switch (i / 4)
                            {
                                case 0:
                                    day = daysOfWeek.Monday;
                                    break;
                                case 1:
                                    day = daysOfWeek.Tuesday;
                                    break;
                                case 2:
                                    day = daysOfWeek.Wednesday;
                                    break;
                                case 3:
                                    day = daysOfWeek.Thursday;
                                    break;
                                case 4:
                                    day = daysOfWeek.Friday;
                                    break;
                                case 5:
                                    day = daysOfWeek.Saturday;
                                    break;
                                case 6:
                                    day = daysOfWeek.Sunday;
                                    break;
                                default: 
                                    day = daysOfWeek.None;
                                    break;
                            }

                            Char checkLesson = (schedule & (byte)day) > 0 ? '+' : '-';

                            Console.Write("{0}", day.ToString().Remove(3));
                            Console.SetCursorPosition(x + 1, y + j + 1);
                            Console.Write("---");
                            Console.SetCursorPosition(x + 1, y + j + 2);
                            Console.Write(" {0} ", checkLesson);
                        }
                    }

                    Console.SetCursorPosition(++x, y);
                }
                else
                {
                    Console.SetCursorPosition(++x, y);
                }
            }
        }

        private static void addLesson()
        {
            int x = 0;
            int y = 7;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("Отметьте в какие дни будут проходить уроки, ответ нужно дать \"+\" будет урок, \"-\" не будет.");

            byte result = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(x, ++y);
                Console.WriteLine("\nВ {0} есть урок?", Enum.GetNames(typeof(daysOfWeek))[i]);

                char key = Console.ReadKey(true).KeyChar;

                if (key == '+')
                {
                    switch (i)
                    {
                        case 0:
                            result |= (int)daysOfWeek.Monday;
                            break;
                        case 1:
                            result |= (int)daysOfWeek.Tuesday;
                            break;
                        case 2:
                            result |= (int)daysOfWeek.Wednesday;
                            break;
                        case 3:
                            result |= (int)daysOfWeek.Thursday;
                            break;
                        case 4:
                            result |= (int)daysOfWeek.Friday;
                            break;
                        case 5:
                            result |= (int)daysOfWeek.Saturday;
                            break;
                        case 6:
                            result |= (int)daysOfWeek.Sunday;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }

                    drawTable(result);
                }
            }
        }
    }
}

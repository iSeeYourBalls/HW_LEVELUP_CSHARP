using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            chooseTask();
        }

        private static void mess(string str)
        {
            byte count = 0;
            double max = 0.0;
            double min = 0.0;
            double lowMin = 0.0;
            double lowMax = 0.0;

            for (; ; )
            {
                if (count > 0)
                {
                    str = "Введите следующие число";
                }

                Console.WriteLine(str);
                string input = Console.ReadLine().Replace(" ", "").Replace(".", ",");

                if (!isDigit(input.ToCharArray()))
                {
                    Console.WriteLine("\nОдин из символов не является числом, повторить попытку Y/N?");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        continue;
                    }

                    break;
                }
                else
                {
                    double inputVal = double.Parse(input);

                    if (count == 0)
                    {
                        max = inputVal;
                        min = inputVal;
                        lowMax = inputVal;
                        lowMin = inputVal;
                    }

                    if (max < inputVal)
                    {
                        lowMax = max;
                        max = inputVal;

                        if (min >= lowMin)
                        {
                            lowMin = inputVal;
                        }
                    }
                    else
                    {
                        if (inputVal > lowMax || max <= lowMax)
                        {
                            lowMax = inputVal;
                        }

                        if (min > inputVal)
                        {
                            lowMin = min;
                            min = inputVal;
                        }
                        else
                        {
                            if (inputVal > min && inputVal < lowMin)
                            {
                                lowMin = inputVal;
                            }
                        }
                    }

                    if (++count == 5)
                    {
                        result(max, min, lowMin, lowMax);
                        break;
                    }
                }
            }
        }

        //Проверка строки на наличие букв
        private static bool isDigit(char[] charArr)
        {
            foreach (char symbol in charArr)
            {
                if (!char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        //Проверка строки на наличие букв // перегрузка
        private static bool isDigit(char symbol)
        {
            if (!char.IsDigit(symbol))
            {
                return false;
            }

            return true;
        }

        //Результат первого
        private static void result(double maxVal, double minVal, double lowMin, double lowMax)
        {
            Console.WriteLine("Макс значение {0}, макс близкое {3}, мин значение {1}, мин близкое {2}", maxVal, minVal, lowMin, lowMax);
            Console.ReadKey();
        }

        //Второе ДЗ
        private static byte dayOfWeek(string day)
        {
            if(isEnglish(day.ToCharArray()))
            {
                switch (day.ToLower())
                {
                    case "sunday": return 1;
                    case "monday": return 2;
                    case "tuesday": return 3;
                    case "wednesday": return 4;
                    case "thursday": return 5;
                    case "friday": return 6;
                    case "saturday": return 7;
                    default: return 0;
                }
            }
            else
            {
                switch (day.ToLower())
                {
                    case "понедельник": return 1;
                    case "вторник": return 2;
                    case "среда": return 3;
                    case "четверг": return 4;
                    case "пятница": return 5;
                    case "суббота": return 6;
                    case "воскресенье": return 7;
                    default: return 0;
                }
            }
        }

        //Проверка на анг буквы
        private static bool isEnglish(char[] charArr)
        {
            foreach (char symbol in charArr)
            {
                if ((int)symbol>=65 && symbol<=122)
                {
                    return true;
                }
            }

            return false;
        }

        //Основной второго ДЗ
        private static void numberOfDay()
        {
            Console.WriteLine("\nВведите день недели :");
            string input = Console.ReadLine();
            byte numberDay = dayOfWeek(input);
            if (numberDay > 0)
            {
                Console.WriteLine("Номер дня недели равен {0}", numberDay);
            }
            else
            {
                Console.WriteLine("Введен не корректный день недели \"{0}\", повторить попытку Y/N?", input);
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    numberOfDay();
                }
            }
            Console.Read();
        }

        //Метод начала
        private static void chooseTask()
        {
            Console.WriteLine("Выберите номер домашнего задания.\nСписок домашний заданий : \n 1. Перебрать 5 цифр if/else; \n 2. Номер дня недели switch \n 3. Числа через массив \n 4. Читаем разными циклами \nСделайте свой выбор :");

            char symbol = Console.ReadKey().KeyChar;

            if (!isDigit(symbol))
            {
                Console.WriteLine("\nCимвол не является числом, повторить попытку Y/N?");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    chooseTask();
                }
            }
            else
            {
                switch (symbol)
                {
                    case '1': mess("\nНеобходимо ввести 5 цифр, введите первую :"); break;
                    case '2': numberOfDay(); break;
                    case '3': cycle(); break;
                    case '4': readCycle(); break;
                    default: Console.WriteLine("\nЗадания с номером {0} не существует.", symbol); Console.ReadKey(); break;
                }
            }
        }

        //3 ДЗ с циклами

        private static void cycle()
        {
            Console.WriteLine("\nНеобходимо ввести цифры в строку через запятую.");
            string input = Console.ReadLine().Replace(" ", "");
            Char delimiter = ',';
            String[] substrings = input.Split(delimiter);

            if (!isDigit(input.Replace(",", "").Replace(".", "").ToCharArray()))
            {
                Console.WriteLine("\nОдин из символов не является числом, повторить попытку Y/N?");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    cycle();
                }

                return;
            }

            double max = 0.0;
            double min = 0.0;
            double lowMin = 0.0;
            double lowMax = 0.0;

            for (int i = 0; i < substrings.Length; i++)
            {
                double inputVal = double.Parse(substrings[i].Replace(".",","));

                Console.WriteLine("Введена цифра : {0}\n", inputVal);

                if (i == 0)
                {
                    max = inputVal;
                    min = inputVal;
                    lowMax = inputVal;
                    lowMin = inputVal;
                }

                if (max < inputVal)
                {
                    lowMax = max;
                    max = inputVal;

                    if (min >= lowMin)
                    {
                        lowMin = inputVal;
                    }
                }
                else
                {
                    if (inputVal > lowMax || max <= lowMax)
                    {
                        lowMax = inputVal;
                    }

                    if (min > inputVal)
                    {
                        lowMin = min;
                        min = inputVal;
                    }
                    else
                    {
                        if (inputVal > min && inputVal < lowMin)
                        {
                            lowMin = inputVal;
                        }
                    }
                }
            }

            result(max, min, lowMin, lowMax);
        }

        // Читаем разными циклами
        private static void readCycle()
        {
            string [] arrNames = {"Петя", "Вася", "Федор", "Гриша", "Евдакентий", "Валя", "Галя"};

            Console.WriteLine("Читаем при помощи foreach");
            foreach (string name in arrNames)
            {
                Console.WriteLine("\nИмя : {0}", name);
            }

            Console.WriteLine("\nЧитаем при помощи for");
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.WriteLine("\nИмя : {0}", arrNames[i]);
            }

            Console.WriteLine("\nЧитаем при помощи while");
            int j = 0;
            while (j < arrNames.Length)
            {
                Console.WriteLine("\nИмя : {0}", arrNames[j]);
                j++;
            }

            Console.WriteLine("\nЧитаем при помощи do while");

            j = 0;
            do
            {
                Console.WriteLine("\nИмя : {0}", arrNames[j]);

                j++;
            }
            while (j < arrNames.Length);

            Console.ReadKey();
        }

    }
}

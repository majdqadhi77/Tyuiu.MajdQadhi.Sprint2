﻿using Tyuiu.MajdQadhi.Sprint2.Task6.V7.Lib;

namespace Tyuiu.MajdQadhi.Sprint2.Task6.V7
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение переменной StartYear, n");
            int startYear, n;
            startYear = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кадхи М. Н. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Кадхи М. Н. | ИИПБ-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("StartYear: " + startYear + " " + "n: " + n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.FindMonthName(startYear, n);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
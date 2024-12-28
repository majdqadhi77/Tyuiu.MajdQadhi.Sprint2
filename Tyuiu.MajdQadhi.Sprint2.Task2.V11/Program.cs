using Tyuiu.MajdQadhi.Sprint2.Task2.V11.Lib;

namespace Tyuiu.MajdQadhi.Sprint2.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Введите значение переменной х: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится внтури области");
            }
            else
            {
                Console.WriteLine("Точка не находится внтури области");
            }

            Console.ReadKey();
        }
    }
}

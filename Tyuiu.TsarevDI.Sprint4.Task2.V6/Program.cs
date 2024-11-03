using Tyuiu.TsarevDI.Sprint4.Task2.V6.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task2V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                 *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Варинат #6                                                            *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[len];

            for (int i = 0; i < len; i++)
            {
                m[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("массив");
            for (int i = 0; i < len; i++)
                Console.WriteLine(m[i] + "\t");



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(m));
            Console.ReadKey();
        }
    }
}
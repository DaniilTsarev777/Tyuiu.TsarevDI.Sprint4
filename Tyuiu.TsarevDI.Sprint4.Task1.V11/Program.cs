using Tyuiu.TsarevDI.Sprint4.Task1.V11.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                         *");
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Варинат #11                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");

            int len = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение "+i+" элемента массива: ");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i < len; i++)
                Console.WriteLine(m[i] + "\t");

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(m));
            Console.ReadKey();
        }
    }
}

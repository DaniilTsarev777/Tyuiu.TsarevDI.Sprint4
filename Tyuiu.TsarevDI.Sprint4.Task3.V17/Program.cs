using Tyuiu.TsarevDI.Sprint4.Task3.V17.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: вумерные массивы. (статический ввод)                            *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Варинат #11                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            int[,] m = new int[5, 5] { { 6, 4, 2, 2, 1 },
                                       { 3, 6, 5, 4, 1 },
                                       { 5, 2, 3, 1, 6 },
                                       { 8, 8, 4, 5, 3 },
                                       { 7, 4, 5, 1, 6 } };
            int raws, columns;
            raws = m.GetUpperBound(0)+1;
            columns = m.Length / raws;


            Console.WriteLine("Массив");
            for (int i = 0; i < raws; i++)
                for (int j = 0; j < columns; j++)
                    Console.Write($"{m[i, j]}\t");


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(m));
            Console.ReadKey();
        }
    }
}

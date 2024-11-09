using Tyuiu.TsarevDI.Sprint4.Task5.V10.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Random rand = new Random();

            Console.Title = "Спринт #4 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                  *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Варинат #10                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            int rows, columns;

            Console.WriteLine("Введите количество строк в массиве: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] m = new int[rows, columns];

            
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    m[i, j] = rand.Next(-4, 7);

            Console.WriteLine("\nМассив");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
                    
                Console.WriteLine();
            }
                

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(m));













        }
    }
}

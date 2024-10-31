using Tyuiu.TsarevDI.Sprint4.Task0.V10.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] m = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Console.Title = "Спринт #4 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                           *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Варинат #10                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.GetSumOddArrEl(m));
            Console.ReadKey();
        }
    }
}

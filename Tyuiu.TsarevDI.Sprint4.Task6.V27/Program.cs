using Tyuiu.TsarevDI.Sprint4.Task6.V27.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #4                                                             *");
            Console.WriteLine("* Тема: Класс Array                                                     *");
            Console.WriteLine("* Задание #6                                                            *");
            Console.WriteLine("* Варинат #27                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");

            string[] m = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            Console.WriteLine("Исходный массив:");
            foreach (string element in m)
                Console.WriteLine(element);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Количество элементов с длинной меньше 7:");

            Console.WriteLine(ds.Calculate(m));
            Console.ReadKey();


        }
    }
}

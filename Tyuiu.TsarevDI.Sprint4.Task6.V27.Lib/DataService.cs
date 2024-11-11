using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            int s;
            s = 0;
            string[] m = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            foreach (string element in m)
                s = m.Count(t => t.Length < 7);
                
                    
            return s;

        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task4.V24.Lib
{
    public class DataService : ISprint4Task4V24
    {
        public int[,] Calculate(int[,] m)
        {
            int rows, columns, count;
            rows = m.GetUpperBound(0) + 1;
            columns = m.Length / rows;
            count = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (m[i, j] % 2 == 0)
                        m[i, j] = 1;
            return m;



        }
    }
}

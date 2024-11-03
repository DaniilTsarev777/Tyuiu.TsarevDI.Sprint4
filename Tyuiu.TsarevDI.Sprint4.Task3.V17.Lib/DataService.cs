using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] m)
        {
            int rows, columns, s;
            rows = m.GetUpperBound(0) + 1;
            columns = m.Length / rows;
            s = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if ((j == 3) && ((i == 0) || (i == 1) || (i == 2) || (i == 3) || (i == 4)))
                        s += m[i, j];
            return s;

            

        }
    }
}

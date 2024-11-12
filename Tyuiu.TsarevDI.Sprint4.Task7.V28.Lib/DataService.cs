using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] m = new int[rows, columns];

            int p = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    m[i, j] = int.Parse(value.Substring(i*columns+j, 1));
                }
            }

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (m[i, j] % 2 == 0)
                        p *= m[i, j];

            return p;


        }
    }
}

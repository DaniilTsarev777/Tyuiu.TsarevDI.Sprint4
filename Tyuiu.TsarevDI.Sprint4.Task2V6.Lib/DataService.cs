using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task2V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] m)
        {
            int r;
            r = 1;
            for (int i = 0; i < m.Length; i++)
                if (m[i] % 2 != 0)
                    r *= m[i];
            return r;

        }
    }
}

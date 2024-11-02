using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task1.V11.Lib
{
    public class DataService : ISprint4Task1V11
    {
        public int Calculate(int[] m)
        {
            
            int s = 0;
            for (int i = 0; i < m.Length; i++)
                if (m[i] % 2 == 0)
                    s += m[i];
            return s;

        }
    }
}

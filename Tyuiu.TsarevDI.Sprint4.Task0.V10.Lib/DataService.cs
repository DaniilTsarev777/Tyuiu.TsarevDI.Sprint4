using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevDI.Sprint4.Task0.V10.Lib
{
    public class DataService : ISprint4Task0V10
    {
        public int GetSumOddArrEl(int[] array)
        {
            int[] m = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int s = 0;
            for (int i = 0; i < 10; i++)
                if (m[i] % 2 != 0)
                    s += m[i];
            return s;
        }
    }
}

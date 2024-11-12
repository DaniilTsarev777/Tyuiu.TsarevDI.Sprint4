using Tyuiu.TsarevDI.Sprint4.Task7.V28.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
            
        {
            DataService ds = new DataService();
            int rows = 5;
            int columns = 3;
            int[,] m = new int[5, 3];

            string str = "623351179845632";

            Assert.AreEqual(4608, ds.Calculate(rows, columns, str));
        }
    }
}
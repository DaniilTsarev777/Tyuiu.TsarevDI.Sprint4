using Tyuiu.TsarevDI.Sprint4.Task5.V10.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] m = new int[,] { { -1, -2, -3, -4, -4 },
                                    { -1, -2, -3, -4, -4 },
                                    { -1, -2, -3, -4, -4 },
                                    { -1, -2, -3, -4, -4 },
                                    { -1, -2, -3, -4, 5 } };
            Assert.AreEqual(5, ds.Calculate(m));
            
            
        }
    }
}
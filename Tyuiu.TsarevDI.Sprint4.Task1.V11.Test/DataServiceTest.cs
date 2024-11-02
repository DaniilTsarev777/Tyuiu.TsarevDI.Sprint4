using Tyuiu.TsarevDI.Sprint4.Task1.V11.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] m = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            Assert.AreEqual(32, ds.Calculate(m));

        }
    }
}
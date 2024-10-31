using Tyuiu.TsarevDI.Sprint4.Task0.V10.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] m = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            Assert.AreEqual(43, ds.GetSumOddArrEl(m));
        }
    }
}
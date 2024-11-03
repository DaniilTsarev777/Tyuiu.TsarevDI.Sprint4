using Tyuiu.TsarevDI.Sprint4.Task2.V6.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task2V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VakidCalculate()
        {
            DataService ds = new DataService();
            int[] m = { 4, 4, 4, 4, 4, 4, 5, 7, 5, 3, 4, 4, 6, 8, 8};
            Assert.AreEqual(525, ds.Calculate(m));





        }
    }
}
using Tyuiu.TsarevDI.Sprint4.Task6.V27.Lib;
namespace Tyuiu.TsarevDI.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] m = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            Assert.AreEqual(1, ds.Calculate(m));

        }
    }
}
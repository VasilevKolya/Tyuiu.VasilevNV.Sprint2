using Tyuiu.VasilevNV.Sprint2.Task2.V28.Lib;
namespace Tyuiu.VasilevNV.Sprint2.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 15;

            bool res = ds.CheckDotInShadedArea(x, y);
                bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
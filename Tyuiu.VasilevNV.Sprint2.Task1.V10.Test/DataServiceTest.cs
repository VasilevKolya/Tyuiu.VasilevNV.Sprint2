using Tyuiu.VasilevNV.Sprint2.Task1.V10.Lib;
namespace Tyuiu.VasilevNV.Sprint2.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6]{ true, false, false, false, true, false };

          

            
            Assert.AreEqual(wait, res);
        }
    }
}
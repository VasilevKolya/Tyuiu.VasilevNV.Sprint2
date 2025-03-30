using Tyuiu.VasilevNV.Sprint2.Task5.V5.Lib;
namespace Tyuiu.VasilevNV.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServie ds = new DataServie();
            Assert.AreEqual("Шестерка", ds.FindCardValue(6));
            Assert.AreEqual("Семерка", ds.FindCardValue(7));
            Assert.AreEqual("Восьмерка", ds.FindCardValue(8));
            Assert.AreEqual("Девятка", ds.FindCardValue(9));
            Assert.AreEqual("Десятка", ds.FindCardValue(10));
            Assert.AreEqual("Валет", ds.FindCardValue(11));
            Assert.AreEqual("Дама", ds.FindCardValue(12));
            Assert.AreEqual("Король", ds.FindCardValue(13));
            Assert.AreEqual("Туз", ds.FindCardValue(14));
            ds.FindCardValue(5);
        }
    }
}
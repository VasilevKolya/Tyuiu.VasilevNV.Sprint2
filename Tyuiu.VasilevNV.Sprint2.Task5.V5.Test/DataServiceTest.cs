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
            Assert.AreEqual("��������", ds.FindCardValue(6));
            Assert.AreEqual("�������", ds.FindCardValue(7));
            Assert.AreEqual("���������", ds.FindCardValue(8));
            Assert.AreEqual("�������", ds.FindCardValue(9));
            Assert.AreEqual("�������", ds.FindCardValue(10));
            Assert.AreEqual("�����", ds.FindCardValue(11));
            Assert.AreEqual("����", ds.FindCardValue(12));
            Assert.AreEqual("������", ds.FindCardValue(13));
            Assert.AreEqual("���", ds.FindCardValue(14));
            ds.FindCardValue(5);
        }
    }
}
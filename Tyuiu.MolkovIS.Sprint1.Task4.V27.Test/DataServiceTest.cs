using Tyuiu.MolkovIS.Sprint1.Task4.V27.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.5, ds.Calculate(1,9));
            Assert.AreEqual(-1, ds.Calculate(2,9));
        }
    }
}

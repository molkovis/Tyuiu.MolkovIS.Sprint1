using Tyuiu.MolkovIS.Sprint1.Task7.V24.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = -0.230;
            Assert.AreEqual(res, ds.Calculate(5d, 1d));
        }
    }
}

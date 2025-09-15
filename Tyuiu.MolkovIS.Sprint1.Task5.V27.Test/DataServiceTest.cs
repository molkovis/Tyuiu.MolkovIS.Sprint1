using Tyuiu.MolkovIS.Sprint1.Task5.V27.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(3, ds.Calculate(8756300));
            Assert.AreEqual(5, ds.Calculate(1545));
            Assert.AreEqual(4, ds.Calculate(34534455));
            Assert.AreEqual(0, ds.Calculate(56777000));
            Assert.AreEqual(4, ds.Calculate(46784456));
            Assert.AreEqual(8, ds.Calculate(67897897));
            Assert.AreNotEqual(5, ds.Calculate(67897897));
        }
    }
}

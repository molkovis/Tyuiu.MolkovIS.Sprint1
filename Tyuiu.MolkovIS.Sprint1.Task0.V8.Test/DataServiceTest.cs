using Tyuiu.MolkovIS.Sprint1.Task0.V8.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1.875, res);
        }
    }
}

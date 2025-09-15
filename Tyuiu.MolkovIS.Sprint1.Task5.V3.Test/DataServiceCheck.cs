using Tyuiu.MolkovIS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceCheck
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(3, ds.Calculate(124356));
        }
    }
}

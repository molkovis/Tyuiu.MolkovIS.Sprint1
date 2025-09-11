using Tyuiu.MolkovIS.Sprint1.Task1.V12.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            double x = 6;
            double y = 6;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);

            Assert.AreEqual(12d/6d, res);
        }
    }
}

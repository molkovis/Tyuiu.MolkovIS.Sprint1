using Tyuiu.MolkovIS.Sprint1.Task2.V16.Lib;




namespace Tyuiu.MolkovIS.Sprint1.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckPerimetr()
        {
            DataService ds = new DataService();    
            int r = 5;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.AreEqual(31.4, res);
        }
    }
}

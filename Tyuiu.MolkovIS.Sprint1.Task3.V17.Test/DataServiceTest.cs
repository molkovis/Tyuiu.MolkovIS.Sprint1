using Tyuiu.MolkovIS.Sprint1.Task3.V17;
using Tyuiu.MolkovIS.Sprint1.Task3.V17.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckZeroCheck()
        {
            DataService ds = new DataService();
            var res1 = ds.ZeroCheck(17.555); bool ch1 = false;
            var res2 = ds.ZeroCheck(17.505); bool ch2 = true;
            var res3 = ds.ZeroCheck(12451.555); bool ch3 = false;
            var res4 = ds.ZeroCheck(-166.550); bool ch4 = true;
            var res5 = ds.ZeroCheck(-166.555660); bool ch5 = false;
            Assert.AreEqual(ch1, res1);
            Assert.AreEqual(ch2, res2);
            Assert.AreEqual(ch3, res3);
            Assert.AreEqual(ch4, res4);
            Assert.AreEqual(ch5, res5);
        }
    }
}

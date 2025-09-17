using Tyuiu.MolkovIS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.MolkovIS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMethod()
        {
            DataService ds = new DataService();
            string str1 = "aaa.."; bool res1 = true;
            string str2 = "aaa......."; bool res2 = false;
            Assert.AreEqual(res1, ds.CheckLettersCount(str1));
            Assert.AreEqual(res2, ds.CheckLettersCount(str2));

        }
    }
}

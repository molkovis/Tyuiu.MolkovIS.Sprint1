using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolkovIS.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            int h;
            string numString = Convert.ToString(k);
            string a = Convert.ToString(numString[numString.Length - 3]);
            h = Convert.ToInt32(a);
            return h;
        }
    }
}

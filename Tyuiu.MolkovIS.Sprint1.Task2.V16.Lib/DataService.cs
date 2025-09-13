
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolkovIS.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int value)
        {
            return Math.Round(2d *  value * 3.14d, 3);
        }
    }
}

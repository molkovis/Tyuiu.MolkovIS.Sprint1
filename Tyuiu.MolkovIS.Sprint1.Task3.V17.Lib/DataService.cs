using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolkovIS.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            bool res = false;
            number = Math.Abs(number);
            char char0 = '0';
            double a = Math.Floor(number);
            double b = number - a;
            a = Convert.ToInt32(b*10000);
            string c = Convert.ToString(a);
            if ((c[0] == char0) | (c[1] == char0) | (c[2] == char0))
            {
                res = true;
            }

            return res;

        }
    }
}

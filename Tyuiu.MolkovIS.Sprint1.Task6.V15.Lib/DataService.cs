using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolkovIS.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int countBukv = 0;
            int countZnak = 0;
            foreach (char i in value)
            {
                if (char.IsLetter(i))
                    countBukv++;
                else if (char.IsPunctuation(i))
                    countZnak++;
            }
            if (countBukv > countZnak)
                return true;
            else return false;
        }
    }
}

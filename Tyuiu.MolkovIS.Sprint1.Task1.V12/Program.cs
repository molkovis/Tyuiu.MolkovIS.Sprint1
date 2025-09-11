using Tyuiu.MolkovIS.Sprint1.Task1.V12.Lib;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Мольков И. С.| ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт#01                                                               *");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Мольков Иван Сергеевич                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (x+y)/6 и печатает его на экране.        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.WriteLine("Введите значение x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        y = Convert.ToDouble(Console.ReadLine());
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.Calculate(x, y);
        Console.WriteLine(res);
        Console.ReadKey();
        
    }
}
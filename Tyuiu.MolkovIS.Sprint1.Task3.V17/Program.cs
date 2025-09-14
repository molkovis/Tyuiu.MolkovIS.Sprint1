using Tyuiu.MolkovIS.Sprint1.Task3.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Мольков И. С.| ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт#01                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Мольков Иван Сергеевич                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых            *");
        Console.WriteLine("* трех цифр из дробной части заданного вещественного числа цифра 0.       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");


        Console.Write("Введите вещественное число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        DataService ds = new DataService();





        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.ZeroCheck(number);
        if (res)
            Console.WriteLine("Ноль есть среди первых трех цифр из дробной части вашего числа");
        else
            Console.WriteLine("Ноля нет среди первых трех цифр из дробной части вашего числа");
        Console.ReadKey();
    }
}
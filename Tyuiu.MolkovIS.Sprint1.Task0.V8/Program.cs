using Tyuiu.MolkovIS.Sprint1.Task0.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {


        Console.Title = "Спринт #1 | Выполнил: Мольков И. С.| ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт#01                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Мольков Иван Сергеевич                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать консольную программу C#, которая вычисляет выражение           *");
        Console.WriteLine("* 15/2/4                                                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 15/2/4                                                                   *");
        Console.WriteLine("***************************************************************************");








        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        DataService ds = new DataService();

        Console.WriteLine(ds.Calculate());
        Console.ReadKey();
    }
}
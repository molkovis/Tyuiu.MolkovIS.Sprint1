using Tyuiu.MolkovIS.Sprint1.Task6.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Мольков И. С.| ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт#01                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Мольков Иван Сергеевич                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("* Проверить, что в строке больше букв, чем знаков.                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");


        Console.Write("Введите текст: ");
        string UserInput = Console.ReadLine();

        DataService ds = new DataService();





        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.CheckLettersCount(UserInput);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
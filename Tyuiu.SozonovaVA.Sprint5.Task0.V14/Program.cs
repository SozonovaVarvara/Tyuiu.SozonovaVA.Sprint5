using Tyuiu.SozonovaVA.Sprint5.Task0.V14.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Cпринт #5 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                *");
        Console.WriteLine("* Тема: Операции сравнения                                                 *");
        Console.WriteLine("* Задание #0                                                               *");
        Console.WriteLine("* Вариант #14                                                              *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                      *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");
        int input = 3;
        Console.WriteLine(input);
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        string res = ds.SaveToFileTextData(input);
        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();

    }
}

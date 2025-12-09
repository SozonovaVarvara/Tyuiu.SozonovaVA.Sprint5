using Tyuiu.SozonovaVA.Sprint5.Task1.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;

        DataService ds = new DataService();

        Console.Title = "Cпринт #5 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                *");
        Console.WriteLine("* Тема: Операции сравнения                                                 *");
        Console.WriteLine("* Задание #1                  b                                            *");
        Console.WriteLine("* Вариант #21                                                              *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                      *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}
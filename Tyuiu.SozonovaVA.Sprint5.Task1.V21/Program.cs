using Tyuiu.SozonovaVA.Sprint5.Task1.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}
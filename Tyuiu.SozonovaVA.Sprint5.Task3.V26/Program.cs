using Tyuiu.SozonovaVA.Sprint5.Task3.V26.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("*Спринт 5                                                                  *");
        Console.WriteLine("*Тема: Потоковый метод записи данных в бинарный файл.                      *");
        Console.WriteLine("*Задание #3                                                                *");
        Console.WriteLine("*Вариант #26                                                               *");
        Console.WriteLine("*Выполнила: Созонова Варвара Андреевна| АСОиУб-25-1                         *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Дано выражение F(x) = 0.7x^3 + 1.52x^2. Вычислить значение              *");
        Console.WriteLine("* при x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin      *");
        Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 2; // Ваше значение X
        Console.WriteLine($"x = {x}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string path = ds.SaveToFileTextData(x);

        double result;
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            result = reader.ReadDouble();
        }

        Console.WriteLine($"Значение функции F(x) = {result}");
        Console.WriteLine($"Результат сохранён в файл: {path}");

        Console.ReadKey();
    }
}
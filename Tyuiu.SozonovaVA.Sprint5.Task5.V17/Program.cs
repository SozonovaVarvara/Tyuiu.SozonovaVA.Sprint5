using Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл (файл взять из архива согласно вашему варианту. Создать папку  *");
        Console.WriteLine("* в ручную и скопировать в неё файл) в котором есть набор значений.       *");
        Console.WriteLine("* Найти сумму всех простых целых чисел в файле. Полученный результат      *");
        Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх знаков    *");
        Console.WriteLine("* после запятой.                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = $@"C:\Users\Varvara\source\repos\Tyuiu.SozonovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task5.V17\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V17";

        Console.WriteLine(" Данные находятся в файле : " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Сумма элементов файла : " + res);
        Console.ReadKey();
    }
}
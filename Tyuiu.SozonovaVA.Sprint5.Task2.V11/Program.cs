using Tyuiu.SozonovaVA.Sprint5.Task2.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Дан двумерный целочисленный массив 3 на 3 э                              *");

        Console.WriteLine("*заполненный значениями с клавиатуры                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int rows = 3;
        int cols = 3;
        int[,] matr = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Введите {i},{j} элемент массива: ");
                matr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"{matr[i, j]}");

            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");




        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        var result = ds.SaveToFileTextData(matr);
        Console.WriteLine("Файл: " + result);

        foreach (string line in File.ReadLines(result))
        {
            Console.WriteLine(line);
        }

        Console.ReadKey();
    }
}
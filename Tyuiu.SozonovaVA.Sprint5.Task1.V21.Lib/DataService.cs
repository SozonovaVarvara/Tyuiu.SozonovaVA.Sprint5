using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(@"D:\Users\Varvara\source\repos\Tyuiu.SozonovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task1.V21\bin\Debug\net8.0\OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;

            if (filexists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x);
                y = Math.Round(y, 2);
                stry = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }

                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }
            }
            return path;

        }
    }
}

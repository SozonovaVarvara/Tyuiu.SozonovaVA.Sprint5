using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double result = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            result = Math.Round(result, 3);
            File.WriteAllText(outputFile, Convert.ToString(result));
            return outputFile;
        }
    }
}

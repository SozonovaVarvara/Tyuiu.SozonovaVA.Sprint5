using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int number;
                    if ((!int.TryParse(line, out number) || Convert.ToDouble(line) != 2) && Convert.ToDouble(line) != 3 && Convert.ToDouble(line) != 5 && Convert.ToDouble(line) != 7 && Convert.ToDouble(line) != 11 && Convert.ToDouble(line) != 13 && Convert.ToDouble(line) != 17)
                    {
                        continue;
                    }
                    res = res + Convert.ToDouble(line);
                }
                return res;
            }
        }
    }
}

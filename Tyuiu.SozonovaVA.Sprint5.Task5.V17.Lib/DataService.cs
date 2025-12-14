using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            string line;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {

                    for (int i = 2; i < Convert.ToDouble(line); i++)
                    {
                        if (Convert.ToDouble(line) % i == 0)
                        {
                            return 0;
                        }
                        else
                        {
                            sum = sum + Convert.ToDouble(line);
                        }

                    }

                }
            }
            return sum;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            string line;
            string Data = File.ReadAllText(path);
            string[] mas = Data.Split(' ');
            
            //using (StreamReader reader = new StreamReader(Data))
            foreach (string value  in mas)
            {

                //while ((line = reader.ReadLine()) != null)
                {
                    
                    string value1 = value.Replace(".", ",");

                    for (int i = 2; i < Convert.ToDouble(value1); i++)
                    {
                        if (Convert.ToDouble(value1) % i == 0)
                        {
                            return 0;
                        }
                        else
                        {
                            sum = sum + Convert.ToDouble(value1);
                            break;
                        }

                    }

                }
            }
            return Math.Round(sum,2);
        }
    }
}

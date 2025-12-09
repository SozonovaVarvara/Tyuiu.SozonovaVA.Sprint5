using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string[] a = File.ReadAllText(path).Split(' ');

            foreach (string s in a)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (char.IsLower(s[j]) && s[j] >= 'а' && s[j] <= 'я')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}

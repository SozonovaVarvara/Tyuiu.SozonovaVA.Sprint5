using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string pathout = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V6.txt");
            FileInfo fileInfo = new FileInfo(pathout);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathout);
            }
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {

                string str;

                while ((str = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (Char.IsLetter(str[i]) && ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')))
                        {
                            File.AppendAllText(pathout, "#");
                            res = string.Concat(res, '#');
                        }
                        else
                        {
                            File.AppendAllText(pathout, Convert.ToString(str[i]));
                            res = string.Concat(res, str[i]);
                        }
                    }
                }
            }
            return res;
        }
    }
}

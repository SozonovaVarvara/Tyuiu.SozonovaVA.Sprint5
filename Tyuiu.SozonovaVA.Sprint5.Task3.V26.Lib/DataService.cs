using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SozonovaVA.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.txt";
            double y = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            y = Math.Round(y, 3);
            using (BinaryWriter write = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                write.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}

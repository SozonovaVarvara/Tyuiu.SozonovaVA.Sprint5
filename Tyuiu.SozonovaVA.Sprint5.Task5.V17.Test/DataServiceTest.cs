using Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Varvara\source\repos\Tyuiu.SozonovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task5.V17\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V17";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\Varvara\source\repos\Tyuiu.SozonovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task5.V17\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V17";

            DataService ds = new DataService();
            double count = 2;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(count, res);
        }
    }
}

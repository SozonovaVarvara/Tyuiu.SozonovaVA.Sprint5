using Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask5V17.txt" });
            //string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask5V17.txt" });
            //string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

            DataService ds = new DataService();
            double count = 2;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(count, res);
        }
    }
}

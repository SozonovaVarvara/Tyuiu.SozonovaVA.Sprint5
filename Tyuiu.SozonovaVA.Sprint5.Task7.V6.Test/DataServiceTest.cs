using Tyuiu.SozonovaVA.Sprint5.Task7.V6.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string res = ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V6.txt");
            Assert.AreEqual("Привет, #####! #### моя Первая программа.", res);
        }
    }
}

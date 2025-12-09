using Tyuiu.SozonovaVA.Sprint5.Task5.V17.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\Varvara\source\repos\Tyuiu.SozonovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task5.V17\bin\Debug\net8.0\InPutDataFileTask5V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

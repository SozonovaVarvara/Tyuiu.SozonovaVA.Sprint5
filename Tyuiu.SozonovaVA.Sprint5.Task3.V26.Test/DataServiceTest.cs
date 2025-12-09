using Tyuiu.SozonovaVA.Sprint5.Task3.V26.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Varvara\source\repos\Tyuiu.SozovovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task3.V26\bin\Debug\net8.0\OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

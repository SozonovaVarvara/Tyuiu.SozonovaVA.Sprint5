using Tyuiu.SozonovaVA.Sprint5.Task0.V14.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Varvara\source\repos\Tyuiu.SozonovaVA.Sprint5\Tyuiu.SozonovaVA.Sprint5.Task0.V14\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

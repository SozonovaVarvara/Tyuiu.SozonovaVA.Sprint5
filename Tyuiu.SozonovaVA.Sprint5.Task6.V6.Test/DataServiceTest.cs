using Tyuiu.SozonovaVA.Sprint5.Task6.V6.Lib;
namespace Tyuiu.SozonovaVA.Sprint5.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChaeckExistFile()
        {
            string path = Path.GetTempPath();
            FileInfo fileinfo = new FileInfo(path);
            bool fileexist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexist);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = Path.GetTempPath();

            var res = ds.LoadFromDataFile(path);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}

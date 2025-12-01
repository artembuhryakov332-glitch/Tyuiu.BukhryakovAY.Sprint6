using Tyuiu.BukhryakovAY.Sprint6.Task5.V11.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V11.txt");
            DataService dataServcie = new DataService();
            bool FileStatus = File.Exists(path);
            Assert.IsTrue(FileStatus);
        }
    }
}

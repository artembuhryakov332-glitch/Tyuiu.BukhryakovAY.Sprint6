using Tyuiu.BukhryakovAY.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double wait = 7.37;
            int x = 1;
            double res = dataService.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}

using Tyuiu.BukhryakovAY.Sprint6.Task3.V14.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            int[,] defaultMass = {
                { 1,4,-5,-12,-8},
                { 7,-20,11,-13,6},
                { 2,-12,1,-12,3},
                { -1,-7,-20,-6,17},
                { -3,3,2,13,-17}
            };

            int[,] wait = {
                { 1,4,-5,-12,-8},
                { 7,0,11,-13,0},
                { 2,-12,1,-12,3},
                { -1,-7,-20,-6,17},
                { -3,3,2,13,-17}
            };
            int[,] res = service.Calculate(defaultMass);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

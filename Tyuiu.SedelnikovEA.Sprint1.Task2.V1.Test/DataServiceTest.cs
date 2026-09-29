using Tyuiu.SedelnikovEA.Sprint1.Task2.V1.Lib;

namespace Tyuiu.SedelnikovEA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 50;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(31.075, res);
        }
    }
}

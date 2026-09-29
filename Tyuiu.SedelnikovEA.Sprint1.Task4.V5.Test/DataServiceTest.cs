using Tyuiu.SedelnikovEA.Sprint1.Task4.V5.Lib;

namespace Tyuiu.SedelnikovEA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -1.0;
            double y = 9.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}

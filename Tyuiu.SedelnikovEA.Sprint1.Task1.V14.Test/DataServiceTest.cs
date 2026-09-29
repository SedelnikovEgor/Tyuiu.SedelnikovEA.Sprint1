using Tyuiu.SedelnikovEA.Sprint1.Task1.V14.Lib;

namespace Tyuiu.SedelnikovEA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 6.0;
            double b = 2.0;
            double c = 4.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(4.0, res);
        }
    }
}

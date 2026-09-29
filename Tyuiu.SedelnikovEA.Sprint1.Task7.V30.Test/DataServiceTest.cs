using Tyuiu.SedelnikovEA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.SedelnikovEA.Sprint1.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(11.978, res);
        }
    }
}

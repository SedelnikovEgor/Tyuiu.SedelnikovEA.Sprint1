using Tyuiu.SedelnikovEA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.SedelnikovEA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 4.0;
            double b = 3.5;
            var res = ds.CylinderVolume(a,b);
            Assert.AreEqual(153.938, res);
        }
    }
}

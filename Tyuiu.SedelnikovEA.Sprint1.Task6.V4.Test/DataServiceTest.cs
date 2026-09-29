using Tyuiu.SedelnikovEA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.SedelnikovEA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Hello world to all of you";
            var res = ds.MoveLetterToStart(value);
            Assert.AreEqual("oHell dworl ot lal fo uyo", res);
        }
    }
}

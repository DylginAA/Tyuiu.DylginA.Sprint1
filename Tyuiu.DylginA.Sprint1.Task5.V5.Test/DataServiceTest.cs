using Tyuiu.DylginA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 32.597;
            var res = ds.Calculate(x);
            var wait = 5;
            Assert.AreEqual(wait, res);

        }
    }
}
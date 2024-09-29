using Tyuiu.DylginA.Sprint1.Task4.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            var res = ds.Calculate(x,y);
            var wait = 3;
            Assert.AreEqual(wait, res);

        }
    }
}
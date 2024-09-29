using Tyuiu.DylginA.Sprint1.Task1.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;

            var res =  ds.Calculate(x, y);
            Assert.AreEqual(7,res);
           
        }
    }
}
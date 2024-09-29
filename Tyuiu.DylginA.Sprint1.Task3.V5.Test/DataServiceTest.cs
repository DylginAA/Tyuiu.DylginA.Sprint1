using Tyuiu.DylginA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            var res = ds.DistanceLength(3.5, 120);
            var wait = 420;
            Assert.AreEqual(wait, res);

        }
    }
}
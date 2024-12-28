using Tyuiu.MajdQadhi.Sprint2.Task4.V17.Lib;
namespace Tyuiu.MajdQadhi.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 24;
            double b = 1;
            double res1 = 6.003;
            double wail1 = ds.Calculate(a, b);
            Assert.AreEqual(res1, wail1);
            double x = 1;
            double y = 4;
            double res2 = 16;
            double wail2 = ds.Calculate(x, y);
            Assert.AreEqual(res2, wail2);
        }
    }
}
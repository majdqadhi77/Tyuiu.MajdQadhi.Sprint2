

using  Tyuiu.MajdQadhi.Sprint2.Task2.V11.Lib;

namespace Tyuiu.MajdQadhi.Sprint2.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidChekDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 12;
            int y = 11;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(true, res);
        }
    }
}

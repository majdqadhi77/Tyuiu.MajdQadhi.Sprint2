using Tyuiu.MajdQadhi.Sprint2.Task6.V7.Lib;
using System.Net.Http.Headers;

namespace Tyuiu.MajdQadhi.Sprint2.Task6.V7.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestFindMonthName()
    {
        DataService ds = new DataService();
        Assert.AreEqual("������", ds.FindMonthName(1990, 1));
        Assert.AreEqual("�������", ds.FindMonthName(1990, 2));
        Assert.AreEqual("����", ds.FindMonthName(1990, 3));
        Assert.AreEqual("������", ds.FindMonthName(1990, 4));
        Assert.AreEqual("���", ds.FindMonthName(1990, 5));
        Assert.AreEqual("����", ds.FindMonthName(1990, 6));
        Assert.AreEqual("����", ds.FindMonthName(1990, 7));
        Assert.AreEqual("������", ds.FindMonthName(1990, 8));
        Assert.AreEqual("��������", ds.FindMonthName(1990, 9));
        Assert.AreEqual("�������", ds.FindMonthName(1990, 10));
        Assert.AreEqual("������", ds.FindMonthName(1990, 11));
        Assert.AreEqual("�������", ds.FindMonthName(1990, 12));
    }
}
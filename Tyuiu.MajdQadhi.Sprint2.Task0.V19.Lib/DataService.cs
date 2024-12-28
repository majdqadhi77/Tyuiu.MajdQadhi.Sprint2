using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MajdQadhi.Sprint2.Task0.V19.Lib
{
    public class DataService : ISprint2Task0V19
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool [] res = new bool[6];
            res[0] = x + 72 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x + 75 > y;
            res[4] = x <= y;
            res[5] = x + 75 >= y;
            return res;
        }
    }
}
 // x=105 y=177
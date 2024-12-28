using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MajdQadhi.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task4V17
    {
        public double Calculate(double x, double y)
        {
            double z;
            return z = x-22>Math.Pow(y,0.5) ? Math.Round(Math.Pow(6+2/(x*x),y),3): Math.Round( y +12/(x*x),3) ;
        }
    }
}

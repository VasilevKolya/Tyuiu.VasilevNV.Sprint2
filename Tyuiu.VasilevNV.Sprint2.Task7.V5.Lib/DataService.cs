using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VasilevNV.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x >= 0)
            {
                return y >= Math.Pow(x, 2) && y <= Math.Exp(-x);
            }
            else
            {                
                return y >= Math.Pow(x, 2) && y <= Math.Exp(x);
            }
        }
    }
}
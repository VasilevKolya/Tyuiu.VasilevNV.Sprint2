using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VasilevNV.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;

            if (y > x)
                return false;

            if (y > 16 - x)
                return false;

            return true;
        }
    }
}
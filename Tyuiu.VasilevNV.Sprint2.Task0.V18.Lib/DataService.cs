using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VasilevNV.Sprint2.Task0.V18.Lib
{

    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {  
            bool[] res = new bool[6];
            res[0] = x  == y;
            res[1] = x != y;
            res[2] = (x - 4701) < y;
            res[3] = x > (y + 4630);
            res[4] = (x - 4701) <= y;
            res[5] = x >= (y * 11);

            return res;
        }
    }
}

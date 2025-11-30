using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BukhryakovAY.Sprint6.Task4.V21.Lib
{
    public class DataService : ISprint6Task4V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ArrayFunc = new double[len];

            int Index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((2*i - 1) == 0)
                {
                    ArrayFunc[Index] = 0;
                }
                else
                {
                    double res = (2*Math.Cos(i) + 2)/(2*i - 1) + Math.Cos(i) - 5*i + 3;
                    ArrayFunc[Index] = Math.Round(res, 2);
                }
                Index++;
            }
            return ArrayFunc;
        }
    }
}

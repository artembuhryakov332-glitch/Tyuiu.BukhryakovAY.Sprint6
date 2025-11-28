using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BukhryakovAY.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int Index = 0;
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];

            for (int i = startValue; i <= stopValue ; i++)
            {
                if(Math.Sin(i) + 3 == 0)
                {
                    mass[Index] = 0;
                }
                else
                {
                    double result = ((5 * i + 2.5) / (Math.Sin(i) + 3)) + 2 * i + Math.Cos(i);
                    mass[Index] = Math.Round(result, 2);
                }
                Index++;
            }
            return mass;
        }
    }
}

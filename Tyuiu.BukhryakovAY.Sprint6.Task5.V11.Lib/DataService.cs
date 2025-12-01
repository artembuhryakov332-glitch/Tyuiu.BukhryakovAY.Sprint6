using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BukhryakovAY.Sprint6.Task5.V11.Lib
{
    public class DataService : ISprint6Task5V11
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] readFromFile = File.ReadAllLines(path);
            List<double> data = new List<double>();
            foreach (string line in readFromFile)
            {
                if (double.TryParse(line, out double number))
                {
                    if (number % 5 == 0)
                    {
                        data.Add(number);

                    }
                }
            }
            double[] res = data.ToArray();
            return res;
        }
    }
}

using System.Globalization;
using System.Text;
using Tyuiu.BukhryakovAY.Sprint6.Task5.V11.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task5.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        private void buttonFuncStart_AY_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V11.txt");

            this.formsPlotResult_AY.Plot.XLabel("Ocü X");
            this.formsPlotResult_AY.Plot.YLabel("Ocü Y");

            try
            {
                double[] res = dataService.LoadFromDataFile(path);
                string[] lines = File.ReadAllLines(path);

                double[] xValues = new double[res.Length];
                double[] yValues = new double[res.Length];
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < lines.Length; i++)
                {
                    result.AppendLine(lines[i]);
                }
                for(int j = 0; j < res.Length; j++)
                {
                    xValues[j] = j;
                    yValues[j] = res[j];
                }
                this.formsPlotResult_AY.Plot.AddScatter(xValues, yValues);
                this.formsPlotResult_AY.Refresh();
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBoxResult.Text = $"Îøèáêà: {ex.Message}";
            }

        }
    }
}

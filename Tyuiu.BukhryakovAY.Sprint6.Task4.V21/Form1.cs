
using System.Text;
using Tyuiu.BukhryakovAY.Sprint6.Task4.V21.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task4.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_AY_Click(object sender, EventArgs e)
        {

            DataService dataService = new DataService();
            try
            {
                int StartValue = -5;
                int StopValue = 5;

                double[] arrayNum = dataService.GetMassFunction(StartValue, StopValue);

                StringBuilder sb = new StringBuilder();

                this.formsPlotFunc_AY.Plot.Title("График функции sin(x)");
                this.formsPlotFunc_AY.Plot.XLabel("Ocь X");
                this.formsPlotFunc_AY.Plot.YLabel("Ocь Y");

                double[] xValues = new double[arrayNum.Length];
                double[] yValues = new double[arrayNum.Length];

                for (int i = 0; i < arrayNum.Length; i++)
                {
                    xValues[i] = StartValue + i;
                    yValues[i] = arrayNum[i];
                    sb.AppendLine($"{arrayNum[i]}");
                }

                this.formsPlotFunc_AY.Plot.AddScatter(xValues, yValues);
                this.formsPlotFunc_AY.Refresh();

                textBoxFuncResult_AY.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                textBoxFuncResult_AY.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void buttonSave_AY_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V21.txt");
            File.WriteAllText(path, textBoxFuncResult_AY.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formsPlotFunc_AY_Load(object sender, EventArgs e)
        {

        }
    }
}

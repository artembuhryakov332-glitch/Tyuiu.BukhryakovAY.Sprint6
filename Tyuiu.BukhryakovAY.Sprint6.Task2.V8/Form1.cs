using Tyuiu.BukhryakovAY.Sprint6.Task2.V8.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task2.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelStartValue_AY_Click(object sender, EventArgs e)
        {

        }

        private void buttonFuncStart_AY_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            try
            {
                int StartValue = -5;
                int StopValue = 5;
                int len = dataService.GetMassFunction(StartValue, StopValue).Length;

                double[] ArrayFunc = new double[len];
                ArrayFunc = dataService.GetMassFunction(StartValue, StopValue);

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(StartValue), Convert.ToString(ArrayFunc[i]));
                    StartValue++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"что-то пошло не так: {ex}");
            }
        }

        private void groupBoxInfo_AY_Enter(object sender, EventArgs e)
        {

        }
    }
}

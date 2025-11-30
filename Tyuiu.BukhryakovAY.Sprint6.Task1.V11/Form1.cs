using System.Text;
using Tyuiu.BukhryakovAY.Sprint6.Task1.V11.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task1.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBoxInfo_AY_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStart_AY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStop_AY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_AY_TextChanged(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            try
            {
                int StartValue = -5;
                int StopValue = 5;

                double[] arrayNum = dataService.GetMassFunction(StartValue, StopValue);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < arrayNum.Length; i++)
                {
                    int currentValue = StartValue + i;
                    string strLine = $"|  {currentValue,5}  |  {arrayNum[i],8:f2}  |";
                    sb.AppendLine(strLine);
                }

                textBoxResult_AY.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                textBoxResult_AY.Text = $"Îøèáêà: {ex.Message}";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

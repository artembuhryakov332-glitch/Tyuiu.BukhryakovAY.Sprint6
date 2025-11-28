using Tyuiu.BukhryakovAY.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_Info_AY_Enter(object sender, EventArgs e)
        {

        }

        private void task_info_AY_Click(object sender, EventArgs e)
        {

        }

        private void label_image_info_Click(object sender, EventArgs e)
        {

        }

        private void textBox_answer_AY_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 5;
            double res = ds.Calculate(x);
            textBox_answer_AY.Text= Convert.ToString(res);
        }
    }
}

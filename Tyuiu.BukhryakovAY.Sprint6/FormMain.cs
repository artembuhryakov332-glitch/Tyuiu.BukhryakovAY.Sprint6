using Tyuiu.BukhryakovAY.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxInfo_AY_Enter(object sender, EventArgs e)
        {

        }

        private void labelAnswer_AY_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_AY_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            textBoxAnswer_AY.Text = res.ToString();
        }
    }
}

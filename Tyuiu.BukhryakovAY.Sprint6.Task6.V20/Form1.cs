using Tyuiu.BukhryakovAY.Sprint6.Task6.V20.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task6.V20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_AY_Click(object sender, EventArgs e)
        {
            openFileDialog_AY.ShowDialog();
            openFilePath = openFileDialog_AY.FileName;


            textBoxIn_AY.Text = File.ReadAllText(openFilePath);
            buttonOpenFile_AY.Enabled = true;
        }

        private void buttonStart_AY_Click(object sender, EventArgs e)
        {
            textBoxOut_AY.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}

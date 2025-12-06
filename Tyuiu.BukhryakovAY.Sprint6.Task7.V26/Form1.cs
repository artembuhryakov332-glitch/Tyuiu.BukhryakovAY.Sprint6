using System.Windows.Forms;
using Tyuiu.BukhryakovAY.Sprint6.Task7.V26.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task7.V26
{
    public partial class Form1 : Form
    {
        static int colums;
        static int rows;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        String openFilePath;
        DataService ds = new DataService();

        private void buttonFindFile_AY_Click(object sender, EventArgs e)
        {
            openFileDialog_AY.ShowDialog();
            openFilePath = openFileDialog_AY.FileName;
            buttonFindFile_AY.Enabled = true;
            int[,] arrayFromFile = LoadFromFileData(openFilePath);
            dataGridViewIn_AY.ColumnCount = colums;
            dataGridViewIn_AY.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewIn_AY.Rows[i].Cells[j].Value = Convert.ToString(arrayFromFile[i, j]);
                }
            }
            buttonFindFile_AY.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog_AY.FileName = "OutPutFileTask7.csv";
            saveFileDialog_AY.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_AY.ShowDialog();

            string path = saveFileDialog_AY.FileName;
            FileInfo fileInfo = new FileInfo(path);

            int rows = dataGridViewOut_AY.RowCount;
            int columns = dataGridViewOut_AY.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_AY.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_AY.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonGetDone_AY_Click(object sender, EventArgs e)
        {
            int[,] arrayChanged = ds.GetMatrix(openFilePath);
            dataGridViewOut_AY.ColumnCount = colums;
            dataGridViewOut_AY.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewOut_AY.Rows[i].Cells[j].Value = Convert.ToString(arrayChanged[i, j]);
                }
            }
            buttonFindFile_AY.Enabled = true;

        }
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
    }
}

using Tyuiu.BukhryakovAY.Sprint6.Task3.V14.Lib;
namespace Tyuiu.BukhryakovAY.Sprint6.Task3.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        int[,] defaultMatrix = new int[5, 5] {
                { 1,4,-5,-12,-8},
                { 7,-20,11,-13,6},
                { 2,-12,1,-12,3},
                { -1,-7,-20,-6,17},
                { -3,3,2,13,-17}
        };

        private void buttonFuncStart_AY_Click(object sender, EventArgs e)
        {
            int rows = 5;
            int cols = 5;

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            int[,] res = dataService.Calculate(defaultMatrix);

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(res[i,j]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

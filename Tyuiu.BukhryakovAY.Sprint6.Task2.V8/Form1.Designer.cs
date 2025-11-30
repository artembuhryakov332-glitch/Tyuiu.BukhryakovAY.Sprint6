namespace Tyuiu.BukhryakovAY.Sprint6.Task2.V8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxInfo_AY = new GroupBox();
            labelInfo_AY = new Label();
            labelFuncImage_AY = new Label();
            labelStartValue_AY = new Label();
            labelStopValue_AY = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonFuncStart_AY = new Button();
            groupBoxInfo_AY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo_AY
            // 
            groupBoxInfo_AY.Controls.Add(buttonFuncStart_AY);
            groupBoxInfo_AY.Controls.Add(dataGridView1);
            groupBoxInfo_AY.Controls.Add(labelStopValue_AY);
            groupBoxInfo_AY.Controls.Add(labelStartValue_AY);
            groupBoxInfo_AY.Controls.Add(labelFuncImage_AY);
            groupBoxInfo_AY.Controls.Add(labelInfo_AY);
            groupBoxInfo_AY.Location = new Point(12, 12);
            groupBoxInfo_AY.Name = "groupBoxInfo_AY";
            groupBoxInfo_AY.Size = new Size(776, 426);
            groupBoxInfo_AY.TabIndex = 0;
            groupBoxInfo_AY.TabStop = false;
            // 
            // labelInfo_AY
            // 
            labelInfo_AY.AutoSize = true;
            labelInfo_AY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_AY.Location = new Point(18, 32);
            labelInfo_AY.Name = "labelInfo_AY";
            labelInfo_AY.Size = new Size(414, 90);
            labelInfo_AY.TabIndex = 0;
            labelInfo_AY.Text = "Условие:\r\nПроизвести табуляцию функции с -5 до 5\r\nФункция:\r\n";
            // 
            // labelFuncImage_AY
            // 
            labelFuncImage_AY.Image = Properties.Resources.Screenshot_3;
            labelFuncImage_AY.Location = new Point(18, 163);
            labelFuncImage_AY.Name = "labelFuncImage_AY";
            labelFuncImage_AY.Size = new Size(290, 40);
            labelFuncImage_AY.TabIndex = 1;
            // 
            // labelStartValue_AY
            // 
            labelStartValue_AY.AutoSize = true;
            labelStartValue_AY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStartValue_AY.Location = new Point(18, 275);
            labelStartValue_AY.Name = "labelStartValue_AY";
            labelStartValue_AY.Size = new Size(155, 32);
            labelStartValue_AY.TabIndex = 2;
            labelStartValue_AY.Text = "StartValue: -5";
            labelStartValue_AY.Click += labelStartValue_AY_Click;
            // 
            // labelStopValue_AY
            // 
            labelStopValue_AY.AutoSize = true;
            labelStopValue_AY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStopValue_AY.Location = new Point(18, 345);
            labelStopValue_AY.Name = "labelStopValue_AY";
            labelStopValue_AY.Size = new Size(145, 32);
            labelStopValue_AY.TabIndex = 3;
            labelStopValue_AY.Text = "StopValue: 5";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(500, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(202, 342);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.Name = "Column2";
            // 
            // buttonFuncStart_AY
            // 
            buttonFuncStart_AY.Location = new Point(312, 373);
            buttonFuncStart_AY.Name = "buttonFuncStart_AY";
            buttonFuncStart_AY.Size = new Size(102, 47);
            buttonFuncStart_AY.TabIndex = 5;
            buttonFuncStart_AY.Text = "Выполнить";
            buttonFuncStart_AY.UseVisualStyleBackColor = true;
            buttonFuncStart_AY.Click += buttonFuncStart_AY_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInfo_AY);
            Name = "Form1";
            groupBoxInfo_AY.ResumeLayout(false);
            groupBoxInfo_AY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_AY;
        private DataGridView dataGridView1;
        private Label labelStopValue_AY;
        private Label labelStartValue_AY;
        private Label labelFuncImage_AY;
        private Label labelInfo_AY;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonFuncStart_AY;
    }
}

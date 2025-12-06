namespace Tyuiu.BukhryakovAY.Sprint6.Task7.V26
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
            groupBoxIn_AY = new GroupBox();
            dataGridViewIn_AY = new DataGridView();
            groupBoxOut_AY = new GroupBox();
            dataGridViewOut_AY = new DataGridView();
            buttonFindFile_AY = new Button();
            buttonGetDone_AY = new Button();
            buttonSave = new Button();
            openFileDialog_AY = new OpenFileDialog();
            saveFileDialog_AY = new SaveFileDialog();
            groupBoxIn_AY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AY).BeginInit();
            groupBoxOut_AY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AY).BeginInit();
            SuspendLayout();
            // 
            // groupBoxIn_AY
            // 
            groupBoxIn_AY.Controls.Add(dataGridViewIn_AY);
            groupBoxIn_AY.Location = new Point(12, 117);
            groupBoxIn_AY.Name = "groupBoxIn_AY";
            groupBoxIn_AY.Size = new Size(393, 321);
            groupBoxIn_AY.TabIndex = 0;
            groupBoxIn_AY.TabStop = false;
            groupBoxIn_AY.Text = "Ввод:";
            // 
            // dataGridViewIn_AY
            // 
            dataGridViewIn_AY.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewIn_AY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AY.GridColor = SystemColors.GrayText;
            dataGridViewIn_AY.Location = new Point(6, 22);
            dataGridViewIn_AY.Name = "dataGridViewIn_AY";
            dataGridViewIn_AY.Size = new Size(387, 293);
            dataGridViewIn_AY.TabIndex = 0;
            // 
            // groupBoxOut_AY
            // 
            groupBoxOut_AY.Controls.Add(dataGridViewOut_AY);
            groupBoxOut_AY.Location = new Point(411, 117);
            groupBoxOut_AY.Name = "groupBoxOut_AY";
            groupBoxOut_AY.Size = new Size(377, 321);
            groupBoxOut_AY.TabIndex = 1;
            groupBoxOut_AY.TabStop = false;
            groupBoxOut_AY.Text = "Вывод";
            // 
            // dataGridViewOut_AY
            // 
            dataGridViewOut_AY.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewOut_AY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AY.GridColor = SystemColors.GrayText;
            dataGridViewOut_AY.Location = new Point(0, 22);
            dataGridViewOut_AY.Name = "dataGridViewOut_AY";
            dataGridViewOut_AY.Size = new Size(377, 293);
            dataGridViewOut_AY.TabIndex = 0;
            // 
            // buttonFindFile_AY
            // 
            buttonFindFile_AY.Location = new Point(12, 57);
            buttonFindFile_AY.Name = "buttonFindFile_AY";
            buttonFindFile_AY.Size = new Size(124, 54);
            buttonFindFile_AY.TabIndex = 2;
            buttonFindFile_AY.Text = "Загрузить";
            buttonFindFile_AY.UseVisualStyleBackColor = true;
            buttonFindFile_AY.Click += buttonFindFile_AY_Click;
            // 
            // buttonGetDone_AY
            // 
            buttonGetDone_AY.Location = new Point(375, 57);
            buttonGetDone_AY.Name = "buttonGetDone_AY";
            buttonGetDone_AY.Size = new Size(124, 54);
            buttonGetDone_AY.TabIndex = 3;
            buttonGetDone_AY.Text = "Выполнить";
            buttonGetDone_AY.UseVisualStyleBackColor = true;
            buttonGetDone_AY.Click += buttonGetDone_AY_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(195, 57);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(124, 54);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // openFileDialog_AY
            // 
            openFileDialog_AY.FileName = "openFileDialog_AY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonGetDone_AY);
            Controls.Add(buttonFindFile_AY);
            Controls.Add(groupBoxOut_AY);
            Controls.Add(groupBoxIn_AY);
            Name = "Form1";
            Load += Form1_Load;
            groupBoxIn_AY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AY).EndInit();
            groupBoxOut_AY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIn_AY;
        private GroupBox groupBoxOut_AY;
        private DataGridView dataGridViewIn_AY;
        private DataGridView dataGridViewOut_AY;
        private Button buttonFindFile_AY;
        private Button buttonGetDone_AY;
        private Button buttonSave;
        private OpenFileDialog openFileDialog_AY;
        private SaveFileDialog saveFileDialog_AY;
    }
}

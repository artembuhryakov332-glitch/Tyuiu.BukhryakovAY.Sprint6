namespace Tyuiu.BukhryakovAY.Sprint6.Task6.V20
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
            buttonOpenFile_AY = new Button();
            buttonStart_AY = new Button();
            textBoxIn_AY = new TextBox();
            textBoxOut_AY = new TextBox();
            openFileDialog_AY = new OpenFileDialog();
            SuspendLayout();
            // 
            // buttonOpenFile_AY
            // 
            buttonOpenFile_AY.Location = new Point(12, 12);
            buttonOpenFile_AY.Name = "buttonOpenFile_AY";
            buttonOpenFile_AY.Size = new Size(226, 69);
            buttonOpenFile_AY.TabIndex = 0;
            buttonOpenFile_AY.Text = "Открыть файл";
            buttonOpenFile_AY.UseVisualStyleBackColor = true;
            buttonOpenFile_AY.Click += buttonOpenFile_AY_Click;
            // 
            // buttonStart_AY
            // 
            buttonStart_AY.Location = new Point(296, 12);
            buttonStart_AY.Name = "buttonStart_AY";
            buttonStart_AY.Size = new Size(240, 69);
            buttonStart_AY.TabIndex = 1;
            buttonStart_AY.Text = "Выполнить";
            buttonStart_AY.UseVisualStyleBackColor = true;
            buttonStart_AY.Click += buttonStart_AY_Click;
            // 
            // textBoxIn_AY
            // 
            textBoxIn_AY.Location = new Point(12, 152);
            textBoxIn_AY.Multiline = true;
            textBoxIn_AY.Name = "textBoxIn_AY";
            textBoxIn_AY.Size = new Size(378, 286);
            textBoxIn_AY.TabIndex = 2;
            // 
            // textBoxOut_AY
            // 
            textBoxOut_AY.Location = new Point(435, 152);
            textBoxOut_AY.Multiline = true;
            textBoxOut_AY.Name = "textBoxOut_AY";
            textBoxOut_AY.Size = new Size(353, 286);
            textBoxOut_AY.TabIndex = 3;
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
            Controls.Add(textBoxOut_AY);
            Controls.Add(textBoxIn_AY);
            Controls.Add(buttonStart_AY);
            Controls.Add(buttonOpenFile_AY);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile_AY;
        private Button buttonStart_AY;
        private TextBox textBoxIn_AY;
        private TextBox textBoxOut_AY;
        private OpenFileDialog openFileDialog_AY;
    }
}

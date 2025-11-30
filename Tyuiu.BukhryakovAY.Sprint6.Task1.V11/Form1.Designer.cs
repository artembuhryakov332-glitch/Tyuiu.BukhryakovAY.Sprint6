namespace Tyuiu.BukhryakovAY.Sprint6.Task1.V11
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
            textBoxResult_AY = new TextBox();
            textBoxStop_AY = new TextBox();
            textBoxStart_AY = new TextBox();
            labelStop_AY = new Label();
            labelStart_AY = new Label();
            labelImage_AY = new Label();
            labelInfo_AY = new Label();
            groupBoxInfo_AY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo_AY
            // 
            groupBoxInfo_AY.Controls.Add(textBoxResult_AY);
            groupBoxInfo_AY.Controls.Add(textBoxStop_AY);
            groupBoxInfo_AY.Controls.Add(textBoxStart_AY);
            groupBoxInfo_AY.Controls.Add(labelStop_AY);
            groupBoxInfo_AY.Controls.Add(labelStart_AY);
            groupBoxInfo_AY.Controls.Add(labelImage_AY);
            groupBoxInfo_AY.Controls.Add(labelInfo_AY);
            groupBoxInfo_AY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInfo_AY.Location = new Point(12, 12);
            groupBoxInfo_AY.Name = "groupBoxInfo_AY";
            groupBoxInfo_AY.Size = new Size(776, 426);
            groupBoxInfo_AY.TabIndex = 0;
            groupBoxInfo_AY.TabStop = false;
            groupBoxInfo_AY.Enter += groupBoxInfo_AY_Enter;
            // 
            // textBoxResult_AY
            // 
            textBoxResult_AY.Location = new Point(461, 34);
            textBoxResult_AY.Multiline = true;
            textBoxResult_AY.Name = "textBoxResult_AY";
            textBoxResult_AY.Size = new Size(284, 369);
            textBoxResult_AY.TabIndex = 6;
            textBoxResult_AY.TextChanged += textBoxResult_AY_TextChanged;
            // 
            // textBoxStop_AY
            // 
            textBoxStop_AY.Location = new Point(263, 368);
            textBoxStop_AY.Name = "textBoxStop_AY";
            textBoxStop_AY.Size = new Size(100, 35);
            textBoxStop_AY.TabIndex = 5;
            textBoxStop_AY.TextChanged += textBoxStop_AY_TextChanged;
            // 
            // textBoxStart_AY
            // 
            textBoxStart_AY.Location = new Point(15, 368);
            textBoxStart_AY.Name = "textBoxStart_AY";
            textBoxStart_AY.Size = new Size(100, 35);
            textBoxStart_AY.TabIndex = 4;
            textBoxStart_AY.TextChanged += textBoxStart_AY_TextChanged;
            // 
            // labelStop_AY
            // 
            labelStop_AY.AutoSize = true;
            labelStop_AY.Location = new Point(259, 291);
            labelStop_AY.Name = "labelStop_AY";
            labelStop_AY.Size = new Size(104, 30);
            labelStop_AY.TabIndex = 3;
            labelStop_AY.Text = "StopValue";
            // 
            // labelStart_AY
            // 
            labelStart_AY.AutoSize = true;
            labelStart_AY.Location = new Point(15, 291);
            labelStart_AY.Name = "labelStart_AY";
            labelStart_AY.Size = new Size(105, 30);
            labelStart_AY.TabIndex = 2;
            labelStart_AY.Text = "StartValue";
            // 
            // labelImage_AY
            // 
            labelImage_AY.Image = Properties.Resources.Screenshot_2;
            labelImage_AY.Location = new Point(15, 118);
            labelImage_AY.Name = "labelImage_AY";
            labelImage_AY.Size = new Size(314, 99);
            labelImage_AY.TabIndex = 1;
            // 
            // labelInfo_AY
            // 
            labelInfo_AY.AutoSize = true;
            labelInfo_AY.Location = new Point(15, 31);
            labelInfo_AY.Name = "labelInfo_AY";
            labelInfo_AY.Size = new Size(332, 60);
            labelInfo_AY.TabIndex = 0;
            labelInfo_AY.Text = "Условие:\r\nПроизвести табуляцию функции:\r\n";
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_AY;
        private Label labelImage_AY;
        private Label labelInfo_AY;
        private TextBox textBoxResult_AY;
        private TextBox textBoxStop_AY;
        private TextBox textBoxStart_AY;
        private Label labelStop_AY;
        private Label labelStart_AY;
    }
}

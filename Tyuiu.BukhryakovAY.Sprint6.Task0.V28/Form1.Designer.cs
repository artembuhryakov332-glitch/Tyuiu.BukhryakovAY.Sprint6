namespace Tyuiu.BukhryakovAY.Sprint6.Task0.V28
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
            labelImage_AY = new Label();
            labelAnswer_AY = new Label();
            textBoxAnswer_AY = new TextBox();
            groupBoxInfo_AY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo_AY
            // 
            groupBoxInfo_AY.Controls.Add(labelImage_AY);
            groupBoxInfo_AY.Controls.Add(labelInfo_AY);
            groupBoxInfo_AY.Location = new Point(12, 12);
            groupBoxInfo_AY.Name = "groupBoxInfo_AY";
            groupBoxInfo_AY.Size = new Size(776, 319);
            groupBoxInfo_AY.TabIndex = 0;
            groupBoxInfo_AY.TabStop = false;
            groupBoxInfo_AY.Enter += groupBoxInfo_AY_Enter;
            // 
            // labelInfo_AY
            // 
            labelInfo_AY.AutoSize = true;
            labelInfo_AY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_AY.Location = new Point(20, 31);
            labelInfo_AY.Name = "labelInfo_AY";
            labelInfo_AY.Size = new Size(414, 60);
            labelInfo_AY.TabIndex = 0;
            labelInfo_AY.Text = "Условие:\r\nВычислить значние выражения при x = 3\r\n";
            labelInfo_AY.Click += labelInfo_AY_Click;
            // 
            // labelImage_AY
            // 
            labelImage_AY.Image = Properties.Resources.Screenshot_1;
            labelImage_AY.Location = new Point(255, 172);
            labelImage_AY.Name = "labelImage_AY";
            labelImage_AY.Size = new Size(515, 128);
            labelImage_AY.TabIndex = 1;
            // 
            // labelAnswer_AY
            // 
            labelAnswer_AY.AutoSize = true;
            labelAnswer_AY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAnswer_AY.Location = new Point(12, 379);
            labelAnswer_AY.Name = "labelAnswer_AY";
            labelAnswer_AY.Size = new Size(78, 32);
            labelAnswer_AY.TabIndex = 1;
            labelAnswer_AY.Text = "Ответ";
            // 
            // textBoxAnswer_AY
            // 
            textBoxAnswer_AY.Location = new Point(109, 388);
            textBoxAnswer_AY.Name = "textBoxAnswer_AY";
            textBoxAnswer_AY.Size = new Size(134, 23);
            textBoxAnswer_AY.TabIndex = 2;
            textBoxAnswer_AY.TextChanged += textBoxAnswer_AY_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAnswer_AY);
            Controls.Add(labelAnswer_AY);
            Controls.Add(groupBoxInfo_AY);
            Name = "Form1";
            Text = "Form1";
            groupBoxInfo_AY.ResumeLayout(false);
            groupBoxInfo_AY.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInfo_AY;
        private Label labelInfo_AY;
        private Label labelImage_AY;
        private Label labelAnswer_AY;
        private TextBox textBoxAnswer_AY;
    }
}

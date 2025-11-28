namespace Tyuiu.BukhryakovAY.Sprint6
{
    partial class FormMain
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
            groupBoxInfo_AY.Size = new Size(776, 313);
            groupBoxInfo_AY.TabIndex = 0;
            groupBoxInfo_AY.TabStop = false;
            groupBoxInfo_AY.Enter += groupBoxInfo_AY_Enter;
            // 
            // labelInfo_AY
            // 
            labelInfo_AY.AutoSize = true;
            labelInfo_AY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_AY.Location = new Point(6, 19);
            labelInfo_AY.Name = "labelInfo_AY";
            labelInfo_AY.Size = new Size(425, 60);
            labelInfo_AY.TabIndex = 0;
            labelInfo_AY.Text = "Условие:\r\nВычислить значение выражения при x = 3";
            // 
            // labelImage_AY
            // 
            labelImage_AY.Image = Properties.Resources.Screenshot_1;
            labelImage_AY.Location = new Point(6, 115);
            labelImage_AY.Name = "labelImage_AY";
            labelImage_AY.Size = new Size(488, 172);
            labelImage_AY.TabIndex = 1;
            // 
            // labelAnswer_AY
            // 
            labelAnswer_AY.AutoSize = true;
            labelAnswer_AY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAnswer_AY.Location = new Point(18, 372);
            labelAnswer_AY.Name = "labelAnswer_AY";
            labelAnswer_AY.Size = new Size(69, 30);
            labelAnswer_AY.TabIndex = 1;
            labelAnswer_AY.Text = "Ответ";
            labelAnswer_AY.Click += labelAnswer_AY_Click;
            // 
            // textBoxAnswer_AY
            // 
            textBoxAnswer_AY.Location = new Point(103, 379);
            textBoxAnswer_AY.Name = "textBoxAnswer_AY";
            textBoxAnswer_AY.Size = new Size(124, 23);
            textBoxAnswer_AY.TabIndex = 2;
            textBoxAnswer_AY.TextChanged += textBoxAnswer_AY_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAnswer_AY);
            Controls.Add(labelAnswer_AY);
            Controls.Add(groupBoxInfo_AY);
            Name = "FormMain";
            groupBoxInfo_AY.ResumeLayout(false);
            groupBoxInfo_AY.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInfo_AY;
        private Label labelImage_AY;
        private Label labelInfo_AY;
        private Label labelAnswer_AY;
        private TextBox textBoxAnswer_AY;
    }
}

namespace Tyuiu.BukhryakovAY.Sprint6
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
            groupBox_Info_AY = new GroupBox();
            task_info_AY = new Label();
            label_image = new Label();
            label_image_info = new Label();
            label_answer_AY = new Label();
            textBox_answer_AY = new TextBox();
            groupBox_Info_AY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Info_AY
            // 
            groupBox_Info_AY.Controls.Add(label_image_info);
            groupBox_Info_AY.Controls.Add(label_image);
            groupBox_Info_AY.Controls.Add(task_info_AY);
            groupBox_Info_AY.Location = new Point(12, 12);
            groupBox_Info_AY.Name = "groupBox_Info_AY";
            groupBox_Info_AY.Size = new Size(776, 347);
            groupBox_Info_AY.TabIndex = 0;
            groupBox_Info_AY.TabStop = false;
            groupBox_Info_AY.Enter += groupBox_Info_AY_Enter;
            // 
            // task_info_AY
            // 
            task_info_AY.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            task_info_AY.Location = new Point(6, 19);
            task_info_AY.Name = "task_info_AY";
            task_info_AY.Size = new Size(432, 208);
            task_info_AY.TabIndex = 0;
            task_info_AY.Text = "Условие:\r\nВычислить значение выражения при x = 3";
            task_info_AY.Click += task_info_AY_Click;
            // 
            // label_image
            // 
            label_image.AutoSize = true;
            label_image.Image = Properties.Resources.Screenshot_1;
            label_image.Location = new Point(414, 134);
            label_image.Name = "label_image";
            label_image.Size = new Size(0, 15);
            label_image.TabIndex = 1;
            // 
            // label_image_info
            // 
            label_image_info.Image = Properties.Resources.Screenshot_11;
            label_image_info.Location = new Point(6, 134);
            label_image_info.Name = "label_image_info";
            label_image_info.Size = new Size(490, 149);
            label_image_info.TabIndex = 2;
            label_image_info.Click += label_image_info_Click;
            // 
            // label_answer_AY
            // 
            label_answer_AY.AutoSize = true;
            label_answer_AY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_answer_AY.Location = new Point(18, 385);
            label_answer_AY.Name = "label_answer_AY";
            label_answer_AY.Size = new Size(69, 30);
            label_answer_AY.TabIndex = 1;
            label_answer_AY.Text = "Ответ";
            // 
            // textBox_answer_AY
            // 
            textBox_answer_AY.Location = new Point(107, 392);
            textBox_answer_AY.Name = "textBox_answer_AY";
            textBox_answer_AY.Size = new Size(152, 23);
            textBox_answer_AY.TabIndex = 2;
            textBox_answer_AY.TextChanged += textBox_answer_AY_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_answer_AY);
            Controls.Add(label_answer_AY);
            Controls.Add(groupBox_Info_AY);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox_Info_AY.ResumeLayout(false);
            groupBox_Info_AY.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_Info_AY;
        private Label task_info_AY;
        private Label label_image;
        private Label label_image_info;
        private Label label_answer_AY;
        private TextBox textBox_answer_AY;
    }
}

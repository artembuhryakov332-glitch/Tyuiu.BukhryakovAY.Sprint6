namespace Tyuiu.BukhryakovAY.Sprint6.Task4.V21
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
            buttonStart_AY = new Button();
            buttonSave_AY = new Button();
            textBoxFuncResult_AY = new TextBox();
            formsPlotFunc_AY = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // buttonStart_AY
            // 
            buttonStart_AY.Location = new Point(12, 12);
            buttonStart_AY.Name = "buttonStart_AY";
            buttonStart_AY.Size = new Size(150, 50);
            buttonStart_AY.TabIndex = 0;
            buttonStart_AY.Text = "Выполнить";
            buttonStart_AY.UseVisualStyleBackColor = true;
            buttonStart_AY.Click += buttonStart_AY_Click;
            // 
            // buttonSave_AY
            // 
            buttonSave_AY.Location = new Point(12, 91);
            buttonSave_AY.Name = "buttonSave_AY";
            buttonSave_AY.Size = new Size(150, 51);
            buttonSave_AY.TabIndex = 1;
            buttonSave_AY.Text = "Сохранить";
            buttonSave_AY.UseVisualStyleBackColor = true;
            buttonSave_AY.Click += buttonSave_AY_Click;
            // 
            // textBoxFuncResult_AY
            // 
            textBoxFuncResult_AY.Location = new Point(12, 176);
            textBoxFuncResult_AY.Multiline = true;
            textBoxFuncResult_AY.Name = "textBoxFuncResult_AY";
            textBoxFuncResult_AY.Size = new Size(150, 262);
            textBoxFuncResult_AY.TabIndex = 2;
            // 
            // formsPlotFunc_AY
            // 
            formsPlotFunc_AY.Location = new Point(211, 39);
            formsPlotFunc_AY.Margin = new Padding(4, 3, 4, 3);
            formsPlotFunc_AY.Name = "formsPlotFunc_AY";
            formsPlotFunc_AY.Size = new Size(467, 346);
            formsPlotFunc_AY.TabIndex = 3;
            formsPlotFunc_AY.Load += formsPlotFunc_AY_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlotFunc_AY);
            Controls.Add(textBoxFuncResult_AY);
            Controls.Add(buttonSave_AY);
            Controls.Add(buttonStart_AY);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart_AY;
        private Button buttonSave_AY;
        private TextBox textBoxFuncResult_AY;
        private ScottPlot.FormsPlot formsPlotFunc_AY;
    }
}

namespace Tyuiu.BukhryakovAY.Sprint6.Task5.V11
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
            buttonFuncStart_AY = new Button();
            textBoxResult = new TextBox();
            formsPlotResult_AY = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // buttonFuncStart_AY
            // 
            buttonFuncStart_AY.Location = new Point(31, 36);
            buttonFuncStart_AY.Name = "buttonFuncStart_AY";
            buttonFuncStart_AY.Size = new Size(123, 64);
            buttonFuncStart_AY.TabIndex = 0;
            buttonFuncStart_AY.Text = "Выполнить";
            buttonFuncStart_AY.UseVisualStyleBackColor = true;
            buttonFuncStart_AY.Click += buttonFuncStart_AY_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(31, 126);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(123, 312);
            textBoxResult.TabIndex = 1;
            // 
            // formsPlotResult_AY
            // 
            formsPlotResult_AY.Location = new Point(272, 36);
            formsPlotResult_AY.Margin = new Padding(4, 3, 4, 3);
            formsPlotResult_AY.Name = "formsPlotResult_AY";
            formsPlotResult_AY.Size = new Size(467, 346);
            formsPlotResult_AY.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlotResult_AY);
            Controls.Add(textBoxResult);
            Controls.Add(buttonFuncStart_AY);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFuncStart_AY;
        private TextBox textBoxResult;
        private ScottPlot.FormsPlot formsPlotResult_AY;
    }
}

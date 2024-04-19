namespace ex_11__1_
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
            trackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            loopResult = new Label();
            formulaResult = new Label();
            trackBar_value = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // trackBar
            // 
            trackBar.LargeChange = 100;
            trackBar.Location = new Point(65, 49);
            trackBar.Maximum = 100;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(316, 56);
            trackBar.TabIndex = 0;
            trackBar.Tag = "";
            trackBar.TickFrequency = 10;
            trackBar.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 28);
            label1.TabIndex = 1;
            label1.Text = "Количество элементов последовательности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(131, 127);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 2;
            label2.Text = "Способ вычисления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 161);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "В цикле";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 161);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "По формуле";
            // 
            // loopResult
            // 
            loopResult.AutoSize = true;
            loopResult.Location = new Point(25, 192);
            loopResult.MinimumSize = new Size(150, 20);
            loopResult.Name = "loopResult";
            loopResult.Size = new Size(150, 20);
            loopResult.TabIndex = 5;
            loopResult.Text = "0";
            loopResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formulaResult
            // 
            formulaResult.AutoSize = true;
            formulaResult.Location = new Point(260, 192);
            formulaResult.MinimumSize = new Size(150, 20);
            formulaResult.Name = "formulaResult";
            formulaResult.Size = new Size(150, 20);
            formulaResult.TabIndex = 6;
            formulaResult.Text = "0";
            formulaResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar_value
            // 
            trackBar_value.AutoSize = true;
            trackBar_value.Location = new Point(141, 107);
            trackBar_value.MinimumSize = new Size(150, 20);
            trackBar_value.Name = "trackBar_value";
            trackBar_value.Size = new Size(150, 20);
            trackBar_value.TabIndex = 7;
            trackBar_value.Text = "0";
            trackBar_value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 236);
            Controls.Add(trackBar_value);
            Controls.Add(formulaResult);
            Controls.Add(loopResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar);
            MaximizeBox = false;
            MaximumSize = new Size(458, 283);
            MinimumSize = new Size(458, 283);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label loopResult;
        private Label formulaResult;
        private Label trackBar_value;
    }
}

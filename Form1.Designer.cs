namespace ex_10_1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            result = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(198, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 50);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 4;
            label1.Text = "Радиус основания R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 83);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 5;
            label2.Text = "Высота цилиндра h";
            // 
            // result
            // 
            result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            result.AutoSize = true;
            result.Location = new Point(17, 158);
            result.MinimumSize = new Size(450, 20);
            result.Name = "result";
            result.Size = new Size(450, 20);
            result.TabIndex = 6;
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(96, 9);
            label3.Name = "label3";
            label3.Size = new Size(296, 28);
            label3.TabIndex = 7;
            label3.Text = "Вычисление объёма цилиндра";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 203);
            Controls.Add(label3);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(500, 250);
            MinimumSize = new Size(500, 250);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Задание 10 (1)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label result;
        private Label label3;
    }
}

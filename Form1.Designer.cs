namespace ex_10__2_
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
            choice = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            number = new TextBox();
            button1 = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // choice
            // 
            choice.Items.AddRange(new object[] { "2 + 4 + 6 + ... + 2n", "n(n + 1)" });
            choice.Location = new Point(331, 45);
            choice.Name = "choice";
            choice.Size = new Size(151, 28);
            choice.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 1;
            label1.Text = "Способ вычисления суммы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(317, 25);
            label2.TabIndex = 2;
            label2.Text = "Количество элементов последовательности";
            label2.UseCompatibleTextRendering = true;
            // 
            // number
            // 
            number.Location = new Point(331, 12);
            number.Name = "number";
            number.Size = new Size(151, 27);
            number.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(204, 84);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(5, 125);
            result.MinimumSize = new Size(490, 0);
            result.Name = "result";
            result.Size = new Size(490, 20);
            result.TabIndex = 5;
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 161);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(number);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(choice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox choice;
        private Label label1;
        private Label label2;
        private TextBox number;
        private Button button1;
        private Label result;
    }
}

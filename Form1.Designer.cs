namespace ex_11__2_
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
            label5 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            label3 = new Label();
            Sorting = new Button();
            Generating = new Button();
            textBox = new TextBox();
            label2 = new Label();
            Search = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(270, 36);
            label5.Margin = new Padding(3, 0, 3, 10);
            label5.MaximumSize = new Size(250, 1000);
            label5.MinimumSize = new Size(250, 204);
            label5.Name = "label5";
            label5.Size = new Size(250, 204);
            label5.TabIndex = 11;
            label5.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 204);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 1;
            label1.Text = "Список людей из файла";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(208, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // Sorting
            // 
            Sorting.Location = new Point(12, 250);
            Sorting.Name = "Sorting";
            Sorting.Size = new Size(111, 29);
            Sorting.TabIndex = 5;
            Sorting.Text = "Сортировать";
            Sorting.UseVisualStyleBackColor = true;
            Sorting.Click += SortingButton_Click;
            // 
            // Generating
            // 
            Generating.Location = new Point(129, 250);
            Generating.Name = "Generating";
            Generating.Size = new Size(121, 29);
            Generating.TabIndex = 6;
            Generating.Text = "Генерировать";
            Generating.UseVisualStyleBackColor = true;
            Generating.Click += GeneratingButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 311);
            textBox.Name = "textBox";
            textBox.Size = new Size(125, 27);
            textBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 288);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 8;
            label2.Text = "Поиск по фамилии:";
            // 
            // Search
            // 
            Search.Location = new Point(143, 311);
            Search.Name = "Search";
            Search.Size = new Size(107, 29);
            Search.TabIndex = 9;
            Search.Text = "Найти";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 9);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 10;
            label4.Text = "Результаты поиска";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(533, 348);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Search);
            Controls.Add(label2);
            Controls.Add(textBox);
            Controls.Add(Generating);
            Controls.Add(Sorting);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listBox1);
            MaximumSize = new Size(551, 1000);
            MinimumSize = new Size(551, 395);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label3;
        private Button Sorting;
        private Button Generating;
        private TextBox textBox;
        private Label label2;
        private Button Search;
        private Label label4;
        private Label label5;
    }
}

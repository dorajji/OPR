namespace ex_11__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Znak[] persons = Znak.ToList(@"C:\Users\krole\Desktop\Info.txt");
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(persons[i].name);
            }
        }

        private void GeneratingButton_Click(object sender, EventArgs e)
        {
            CreatePersons();
            listBox1.Items.Clear();
            Znak[] persons = Znak.ToList(@"C:\Users\krole\Desktop\Info.txt");
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(persons[i].name);
            }
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Znak[] persons = Znak.ToList(@"C:\Users\krole\Desktop\Info.txt");
            persons = Znak.Sort(persons);
            FileInfo file = new FileInfo(@"C:\Users\krole\Desktop\Info.txt");
            StreamWriter sw = file.CreateText();
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(persons[i].ToString());
                listBox1.Items.Add(persons[i].name);
            }
            sw.Close();
        }
        void CreatePersons()
        {
            string[] first_name = ["���������", "�����", "������", "��������", "��������", "������", "����", "�������", "������", "�����"];
            string[] second_name = ["�������", "�������", "�������", "�����������", "�������", "���������", "���������", "���������", "������", "������"];
            string[] znak = ["�������", "�������", "����", "����", "�����", "��������", "���", "���", "����", "����", "��������", "�������"];
            Random r = new Random();
            FileInfo file = new FileInfo(@"C:\Users\krole\Desktop\Info.txt");
            StreamWriter sw = file.CreateText();
            int znak_;
            Znak[] persons = new Znak[10];
            for (int i = 0; i < 10; i++)
            {
                persons[i].name = $"{first_name[r.Next(10)]} {second_name[r.Next(10)]}";
                znak_ = r.Next(12);
                persons[i].znak = znak[znak_];
                persons[i].date = new DateTime(r.Next(1950, 2024), znak_ + 1, r.Next(19) + 1);
                sw.WriteLine(persons[i].ToString());
            }
            sw.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string Box_secondName = textBox.Text;
            string SecondName;
            string name;
            int k = 0;
            label5.Visible = true;
            label5.Text = "";
            Znak[] persons = Znak.ToList(@"C:\Users\krole\Desktop\Info.txt");
            label4.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                name = persons[i].name;
                SecondName = name.Substring(name.IndexOf(' ') + 1);
                if (SecondName.ToLower() == Box_secondName.ToLower())
                {
                    label5.Text += persons[i];
                    label5.Text += "\n\n";
                    k++;
                }
            }
            if (k == 0)
            {
                label5.Text = $"������� � �������� {Box_secondName} �� ������";
            }
        }
    }
}

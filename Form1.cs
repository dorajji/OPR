namespace ex_10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R;
            double h;
            try
            {
                R = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                result.Text = "�������� ������ ����� ������� R";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "������� ������� ��������� �������� ������� R";
                return;
            }
            catch
            {
                result.Text = "������!";
                return;
            }
            try
            {
                h = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                result.Text = "�������� ������ ����� ������ h";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "������� ������� ��������� �������� ������ h";
                return;
            }
            catch
            {
                result.Text = "������!";
                return;
            }
            result.Text = Convert.ToString(Math.Round(Math.PI * Math.Pow(R, 2) * h, 2));
        }
    }
}

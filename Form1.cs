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
                result.Text = "Неверный формат ввода радиуса R";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "Слишком большое введенное значение радиуса R";
                return;
            }
            catch
            {
                result.Text = "Ошибка!";
                return;
            }
            try
            {
                h = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                result.Text = "Неверный формат ввода высоты h";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "Слишком большое введенное значение высоты h";
                return;
            }
            catch
            {
                result.Text = "Ошибка!";
                return;
            }
            result.Text = Convert.ToString(Math.Round(Math.PI * Math.Pow(R, 2) * h, 2));
        }
    }
}

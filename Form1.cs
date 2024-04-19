namespace ex_10__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int c = choice.SelectedIndex;
            try
            {
                n = Convert.ToInt32(number.Text);
            }
            catch (FormatException)
            {
                result.Text = "Неверный формат ввода количества элементов последовательности";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "Слишком большое число количества элементов последовательности";
                return;
            }
            catch
            {
                result.Text = "Ошибка!";
                return;
            }
            int ans = 0;
            if (c == 0)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    ans += i * 2;
                }
            }
            else if (c == 1)
            {
                ans = n * (n + 1);
            }
            else
            {
                result.Text = "Выберите способ вычисления суммы";
                return;
            }
            result.Text = Convert.ToString(ans);
        }
    }
}

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
                if (R < 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                result.Text = "Íåâåðíûé ôîðìàò ââîäà ðàäèóñà R";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "Ñëèøêîì áîëüøîå ââåäåííîå çíà÷åíèå ðàäèóñà R";
                return;
            }
            catch
            {
                result.Text = "Îøèáêà!";
                return;
            }
            try
            {
                h = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                result.Text = "Íåâåðíûé ôîðìàò ââîäà âûñîòû h";
                return;
            }
            catch (StackOverflowException)
            {
                result.Text = "Ñëèøêîì áîëüøîå ââåäåííîå çíà÷åíèå âûñîòû h";
                return;
            }
            catch
            {
                result.Text = "Îøèáêà!";
                return;
            }
            result.Text = Convert.ToString(Math.Round(Math.PI * Math.Pow(R, 2) * h, 2));
        }
    }
}

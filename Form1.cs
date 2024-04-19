namespace ex_11__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public long Loop(long n)
        {
            long result = 0;
            while (n > 0)
            {
                result += n * n * n * n * n;
                n--;
            }
            return result;
        }
        public long Formula(long n)
        {
            return n * n * (n + 1) * (n + 1) * (2 * n * n + 2 * n - 1) / 12;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar_value.Text = Convert.ToString(trackBar.Value);
            loopResult.Text = Convert.ToString(Loop(trackBar.Value));
            formulaResult.Text = Convert.ToString(Formula(trackBar.Value));
        }
    }
}

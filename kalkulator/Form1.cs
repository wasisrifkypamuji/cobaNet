namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TAMBAH_Click(object sender, EventArgs e)
        {
            double a = 1111, b = 61111, c;

            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);

            c = a + b;

            C.Text = c.ToString();

        }

        private void KURANG_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c;

            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);

            c = a - b;

            C.Text = c.ToString();

        }

        private void KALI_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c;

            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);

            c = a * b;

            C.Text = c.ToString();

        }

        private void BAGI_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c;

            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);

            c = a / b;

            C.Text = c.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            A.Clear();
            B.Clear();
            C.Clear();
            //anjayyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
        }
    }
}

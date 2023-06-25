namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y, taghsim;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            taghsim = x / y;
            label3.Text = "taghsim is:" + Convert.ToString(taghsim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("eror");
            }
            else
            {
                int x, y, sum;
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                sum = x + y;
                label3.Text = "sum is:" + Convert.ToString(sum);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y, tafrigh;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            tafrigh = x - y;
            label3.Text = "tafrigh is:" + Convert.ToString(tafrigh);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y, zarb;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            zarb = x * y;
            label3.Text = "zarb is:" + Convert.ToString(zarb);
        }
    }
}
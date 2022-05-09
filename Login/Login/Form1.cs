namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.aa = textBox1.Text;
            string u = textBox1.Text;
            string p = textBox2.Text;
            Main M = new Main();
            if(u == "lenglee")
            {
                if(p == "1234")
                {
                    M.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Try again","Error");
                }
            }
            else
            {
                MessageBox.Show("Try again","Error");
            }
        }
    }
}
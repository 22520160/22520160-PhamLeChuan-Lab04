namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai01_Click(object sender, EventArgs e)
        {
            Bai01 f = new Bai01();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 f = new Bai02();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 f = new Bai03();
            f.Show();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05 f = new Bai05();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai06 f = new Bai06();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

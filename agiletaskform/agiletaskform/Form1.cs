namespace agiletaskform
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (username == "Kenan" && password == "Kenan123")

            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (username == "Kenan" && password == "Kenan123")

            {
                User user = new User();
                user.Show();
                this.Hide();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agiletaskform
{
    public partial class Balans : Form
    {
        private double balance;
       
        public Balans()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(textBox2.Text, out amount))
            {
                balance = amount;

                updateBalanse();

            }

        }

        private void updateBalanse()
        {

            double deyer;
            deyer = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (deyer + balance).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }




    }
}

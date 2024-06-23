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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Balans balans = new Balans();
            balans.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gridview gridview = new Gridview();
            gridview.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

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
    public partial class Gridview : Form
    {


        public Gridview()
        {
            InitializeComponent();

        }

        private void Gridview_Load(object sender, EventArgs e)
        {



            DataTable dt = new DataTable();
            dt.Columns.Add("adi");
            dt.Columns.Add("markasi");
            dt.Columns.Add("qiymeti");
            dt.Columns.Add("sayi");

            dt.Rows.Add("Telefon", "Iphone 15", 2500, 20);
            dt.Rows.Add("Avtomobil", "BMW M5", 50000, 15);
            dt.Rows.Add("Komputer", "HP", 3200, 30);

            dataGridView2.DataSource = dt;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 && int.TryParse(textBox1.Text, out int daxiledilensay))
            {
                int Mehsulunsayi = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["sayi"].Value);

                if (daxiledilensay <= Mehsulunsayi)
                {
                    dataGridView2.SelectedRows[0].Cells["sayi"].Value = Mehsulunsayi - daxiledilensay;
                    MessageBox.Show("Sebete elave olundu");
                }
                else
                {
                    MessageBox.Show("Kifayet qeder mehsul yoxdu");
                }
            }
            else
            {
                MessageBox.Show("Duzgun say daxil edin");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 && int.TryParse(textBox3.Text, out int daxiledilenqiymet ) && int.TryParse(textBox1.Text,  out int  daxiledilensay))
            {
                int Mehsulunqiymeti = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["qiymeti"].Value);
                int Mehsulunsayi = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["sayi"].Value);

                if ( daxiledilensay <= Mehsulunsayi && daxiledilenqiymet >= (daxiledilensay * Mehsulunqiymeti))
                {
                    
                    MessageBox.Show("Alindi");
                }
                else
                {
                    MessageBox.Show("Ya mebleg kifayet etmir ya say");
                }
            }
            else
            {
                MessageBox.Show("Duzgun qiymet ve ya say daxil edin");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }
    }
}

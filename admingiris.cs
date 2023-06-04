using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yüztakipsistemi
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '●';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text == "admin" && txtSifre.Text == "adminpassw")
            {
                MessageBox.Show("Giriş Başarılı");
                {
                    new AdminPanel().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Anasayfa göster = new Anasayfa();
            göster.Show();
        }
    }
}

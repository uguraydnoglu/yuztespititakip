using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yüztakipsistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            admingiris göster = new admingiris();
            göster.Show();
        }

        private void Kullanıcı_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database = dbUsers; user ID=postgres; password=admin");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into giris", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Giriş kaydı başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into cikis", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Çıkış kaydı başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

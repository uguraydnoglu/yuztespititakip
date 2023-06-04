using System.Diagnostics.Metrics;
using System.Reflection;

namespace yüztakipsistemi
{
    public partial class baslangic : Form
    {
        public baslangic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int süre;
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre++;
            if (süre >= 50)
            {
                timer1.Enabled = false;
                this.Hide();
                Anasayfa form2 = new Anasayfa();
                form2.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
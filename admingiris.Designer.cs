namespace yüztakipsistemi
{
    partial class admingiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admingiris));
            panel1 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            txtSifre = new TextBox();
            label3 = new Label();
            txtKullanıcıAdı = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtKullanıcıAdı);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(250, 25);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(299, 398);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 296);
            button1.Name = "button1";
            button1.Size = new Size(194, 35);
            button1.TabIndex = 8;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ActiveBorder;
            checkBox1.Location = new Point(129, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Şifre Göster";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Location = new Point(57, 167);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(194, 23);
            txtSifre.TabIndex = 4;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(57, 140);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 3;
            label3.Text = "Şifre";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Anchor = AnchorStyles.Left;
            txtKullanıcıAdı.BorderStyle = BorderStyle.None;
            txtKullanıcıAdı.Location = new Point(57, 114);
            txtKullanıcıAdı.Multiline = true;
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(194, 23);
            txtKullanıcıAdı.TabIndex = 2;
            txtKullanıcıAdı.TextChanged += txtKullanıcıAdı_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(57, 87);
            label2.Name = "label2";
            label2.Size = new Size(89, 24);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 69);
            label1.TabIndex = 0;
            label1.Text = "Yetkili Giriş Ekranı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(39, 39, 58);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(39, 39, 58);
            button4.Location = new Point(749, 12);
            button4.Name = "button4";
            button4.Size = new Size(39, 30);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // admingiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admingiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admingiris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox txtSifre;
        private Label label3;
        private TextBox txtKullanıcıAdı;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button4;
    }
}
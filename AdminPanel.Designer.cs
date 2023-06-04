namespace yüztakipsistemi
{
    partial class AdminPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            pictureBox1 = new PictureBox();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            exit = new Button();
            Kullanıcı = new Label();
            panelmenü = new Panel();
            button2 = new Button();
            button1 = new Button();
            txtNum = new TextBox();
            txtKimlik = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelmenü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(285, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 445);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(button4);
            panelLogo.Controls.Add(button3);
            panelLogo.Controls.Add(exit);
            panelLogo.Controls.Add(Kullanıcı);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1100, 77);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(476, 12);
            label2.Name = "label2";
            label2.Size = new Size(87, 46);
            label2.TabIndex = 9;
            label2.Text = "Süre";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(39, 39, 58);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(39, 39, 58);
            button4.Location = new Point(1021, 12);
            button4.Name = "button4";
            button4.Size = new Size(65, 52);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(39, 39, 58);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(39, 39, 58);
            button3.Location = new Point(1295, 12);
            button3.Name = "button3";
            button3.Size = new Size(65, 52);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(39, 39, 58);
            exit.BackgroundImageLayout = ImageLayout.Zoom;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.ForeColor = Color.FromArgb(39, 39, 58);
            exit.Location = new Point(1295, 12);
            exit.Name = "exit";
            exit.Size = new Size(65, 52);
            exit.TabIndex = 4;
            exit.UseVisualStyleBackColor = false;
            // 
            // Kullanıcı
            // 
            Kullanıcı.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Kullanıcı.ForeColor = Color.White;
            Kullanıcı.ImageAlign = ContentAlignment.TopLeft;
            Kullanıcı.Location = new Point(101, 12);
            Kullanıcı.Name = "Kullanıcı";
            Kullanıcı.Size = new Size(179, 25);
            Kullanıcı.TabIndex = 2;
            Kullanıcı.Text = "Yetkili Paneli";
            Kullanıcı.Click += Kullanıcı_Click;
            // 
            // panelmenü
            // 
            panelmenü.BackColor = Color.FromArgb(51, 51, 76);
            panelmenü.Controls.Add(button2);
            panelmenü.Controls.Add(button1);
            panelmenü.Controls.Add(txtNum);
            panelmenü.Controls.Add(txtKimlik);
            panelmenü.Controls.Add(txtSoyad);
            panelmenü.Controls.Add(txtAd);
            panelmenü.Controls.Add(label5);
            panelmenü.Controls.Add(label4);
            panelmenü.Controls.Add(label3);
            panelmenü.Controls.Add(label1);
            panelmenü.Dock = DockStyle.Left;
            panelmenü.Location = new Point(0, 77);
            panelmenü.Name = "panelmenü";
            panelmenü.Size = new Size(252, 523);
            panelmenü.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(66, 436);
            button2.Name = "button2";
            button2.Size = new Size(128, 40);
            button2.TabIndex = 9;
            button2.Text = "ÇIKIŞ YAP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 340);
            button1.Name = "button1";
            button1.Size = new Size(210, 54);
            button1.TabIndex = 8;
            button1.Text = "KAYIT ET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(23, 287);
            txtNum.MaxLength = 6;
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(210, 23);
            txtNum.TabIndex = 7;
            txtNum.KeyPress += txtNum_KeyPress;
            // 
            // txtKimlik
            // 
            txtKimlik.Location = new Point(23, 215);
            txtKimlik.MaxLength = 11;
            txtKimlik.Name = "txtKimlik";
            txtKimlik.Size = new Size(210, 23);
            txtKimlik.TabIndex = 6;
            txtKimlik.TextChanged += textBox3_TextChanged;
            txtKimlik.KeyPress += txtKimlik_KeyPress;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(23, 143);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(210, 23);
            txtSoyad.TabIndex = 5;
            txtSoyad.KeyPress += txtSoyad_KeyPress;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(25, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(208, 23);
            txtAd.TabIndex = 4;
            txtAd.TextChanged += txtAd_TextChanged;
            txtAd.KeyPress += txtAd_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 250);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 3;
            label5.Text = "Personel Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 178);
            label4.Name = "label4";
            label4.Size = new Size(193, 25);
            label4.TabIndex = 2;
            label4.Text = "T.C Kimlik Numarası:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 106);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 1;
            label3.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(873, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(196, 185);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(pictureBox3);
            Controls.Add(panelmenü);
            Controls.Add(panelLogo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelmenü.ResumeLayout(false);
            panelmenü.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelLogo;
        private Button button3;
        private Button exit;
        private Label Kullanıcı;
        private Panel panelmenü;
        private Label label3;
        private Label label1;
        private TextBox txtNum;
        private TextBox txtKimlik;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace yüztakipsistemi
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            pictureBox1 = new PictureBox();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            exit = new Button();
            Kullanıcı = new Label();
            panelmenü = new Panel();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
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
            pictureBox1.Location = new Point(316, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 428);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(button4);
            panelLogo.Controls.Add(button3);
            panelLogo.Controls.Add(exit);
            panelLogo.Controls.Add(Kullanıcı);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1100, 77);
            panelLogo.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 72;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(476, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 46);
            label1.TabIndex = 8;
            label1.Text = "Süre";
            label1.Click += label1_Click;
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
            Kullanıcı.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Kullanıcı.ForeColor = Color.White;
            Kullanıcı.ImageAlign = ContentAlignment.TopLeft;
            Kullanıcı.Location = new Point(101, 6);
            Kullanıcı.Name = "Kullanıcı";
            Kullanıcı.Size = new Size(170, 58);
            Kullanıcı.TabIndex = 2;
            Kullanıcı.Text = "HOŞGELDİNİZ";
            Kullanıcı.TextAlign = ContentAlignment.MiddleLeft;
            Kullanıcı.Click += Kullanıcı_Click;
            // 
            // panelmenü
            // 
            panelmenü.BackColor = Color.FromArgb(51, 51, 76);
            panelmenü.Controls.Add(button5);
            panelmenü.Controls.Add(pictureBox3);
            panelmenü.Controls.Add(button2);
            panelmenü.Controls.Add(button1);
            panelmenü.Dock = DockStyle.Left;
            panelmenü.Location = new Point(0, 77);
            panelmenü.Name = "panelmenü";
            panelmenü.Size = new Size(252, 523);
            panelmenü.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.SpringGreen;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(23, 299);
            button5.Name = "button5";
            button5.Size = new Size(210, 54);
            button5.TabIndex = 72;
            button5.Text = "ÇIKIŞ YAP";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 141);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 440);
            button2.Name = "button2";
            button2.Size = new Size(210, 60);
            button2.TabIndex = 9;
            button2.Text = "ADMİN PANEL GİRİŞ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 215);
            button1.Name = "button1";
            button1.Size = new Size(210, 54);
            button1.TabIndex = 8;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panelmenü);
            Controls.Add(panelLogo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelmenü.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelLogo;
        private Button button4;
        private Button button3;
        private Button exit;
        private Label Kullanıcı;
        private Panel panelmenü;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private Button button5;
    }
}
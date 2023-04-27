namespace Teretana
{
    partial class DodajClana
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbIme = new TextBox();
            tbPrezime = new TextBox();
            tbBrTel = new TextBox();
            tbEmail = new TextBox();
            tbAdresa = new TextBox();
            tbBrIndex = new TextBox();
            btnSlika = new Button();
            pbSlika = new PictureBox();
            btnDodaj = new Button();
            lbConnection = new Label();
            label8 = new Label();
            rbM = new RadioButton();
            rbZ = new RadioButton();
            pbQR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 53);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Prezime*:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 82);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Broj Tel*:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 111);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Email*:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 140);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Adresa*:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 169);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Br. Index:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 227);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 6;
            label7.Text = "Slika:";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(88, 21);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(210, 23);
            tbIme.TabIndex = 7;
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(88, 50);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(210, 23);
            tbPrezime.TabIndex = 8;
            // 
            // tbBrTel
            // 
            tbBrTel.Location = new Point(88, 79);
            tbBrTel.Name = "tbBrTel";
            tbBrTel.Size = new Size(210, 23);
            tbBrTel.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(88, 108);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(210, 23);
            tbEmail.TabIndex = 10;
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(88, 137);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(210, 23);
            tbAdresa.TabIndex = 11;
            // 
            // tbBrIndex
            // 
            tbBrIndex.Location = new Point(88, 166);
            tbBrIndex.Name = "tbBrIndex";
            tbBrIndex.Size = new Size(210, 23);
            tbBrIndex.TabIndex = 12;
            // 
            // btnSlika
            // 
            btnSlika.Location = new Point(88, 223);
            btnSlika.Name = "btnSlika";
            btnSlika.Size = new Size(75, 23);
            btnSlika.TabIndex = 13;
            btnSlika.Text = "Dodaj sliku";
            btnSlika.UseVisualStyleBackColor = true;
            btnSlika.Click += btnSlika_Click;
            // 
            // pbSlika
            // 
            pbSlika.Image = Properties.Resources.image_processing20210620_28232_baqx1v;
            pbSlika.Location = new Point(345, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(200, 200);
            pbSlika.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlika.TabIndex = 14;
            pbSlika.TabStop = false;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(395, 218);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(150, 40);
            btnDodaj.TabIndex = 15;
            btnDodaj.Text = "Dodaj clana";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // lbConnection
            // 
            lbConnection.AutoSize = true;
            lbConnection.Location = new Point(415, 261);
            lbConnection.Name = "lbConnection";
            lbConnection.Size = new Size(106, 15);
            lbConnection.TabIndex = 16;
            lbConnection.Text = "Baza nije povezana";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 198);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 17;
            label8.Text = "Pol*:";
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Checked = true;
            rbM.Location = new Point(88, 196);
            rbM.Name = "rbM";
            rbM.Size = new Size(36, 19);
            rbM.TabIndex = 18;
            rbM.TabStop = true;
            rbM.Text = "M";
            rbM.UseVisualStyleBackColor = true;
            // 
            // rbZ
            // 
            rbZ.AutoSize = true;
            rbZ.Location = new Point(150, 196);
            rbZ.Name = "rbZ";
            rbZ.Size = new Size(32, 19);
            rbZ.TabIndex = 19;
            rbZ.Text = "Z";
            rbZ.UseVisualStyleBackColor = true;
            // 
            // pbQR
            // 
            pbQR.Location = new Point(239, 208);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(59, 50);
            pbQR.TabIndex = 20;
            pbQR.TabStop = false;
            pbQR.Visible = false;
            // 
            // DodajClana
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(570, 281);
            Controls.Add(pbQR);
            Controls.Add(rbZ);
            Controls.Add(rbM);
            Controls.Add(label8);
            Controls.Add(lbConnection);
            Controls.Add(btnDodaj);
            Controls.Add(pbSlika);
            Controls.Add(btnSlika);
            Controls.Add(tbBrIndex);
            Controls.Add(tbAdresa);
            Controls.Add(tbEmail);
            Controls.Add(tbBrTel);
            Controls.Add(tbPrezime);
            Controls.Add(tbIme);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DodajClana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj clana";
            Load += DodajClana_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbIme;
        private TextBox tbPrezime;
        private TextBox tbBrTel;
        private TextBox tbEmail;
        private TextBox tbAdresa;
        private TextBox tbBrIndex;
        private Button btnSlika;
        private PictureBox pbSlika;
        private Button btnDodaj;
        private Label lbConnection;
        private Label label8;
        private RadioButton rbM;
        private RadioButton rbZ;
        private PictureBox pbQR;
    }
}